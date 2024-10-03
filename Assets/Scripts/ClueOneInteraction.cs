using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the puzzle 1 script. 

public class ClueOneInteraction : MonoBehaviour
{

    [SerializeField]
    GameObject clue;


    [SerializeField]
    GameObject cube1;
    [SerializeField]
    GameObject cube2;
    [SerializeField]
    GameObject cube3;

    [SerializeField]
    GameObject virusArea;

    // Start is called before the first frame update
    string hitName;

    bool marker1 = false; 
    bool marker2 = false;
    bool marker3 = false;   

    void Start()
    {
        clue.SetActive(false); 
        virusArea.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))
            {
                hitName = Hit.transform.name;

                switch (hitName)
                {
                    case "Cube01":
                        cube1.SetActive(false);
                        if (marker2 ||  marker3)
                        {
                            Incorrect(); 

                        } else
                        {
                            marker1 = true;
                        }
                        break;

                    case "Cube02":
                        cube2.SetActive(false);
                        if (marker1 && marker3)
                        {
                            marker2 = true;
                        }
                        else
                        {
                            Incorrect(); 
                        }
                        break;

                    case "Cube03":
                        cube3.SetActive(false);
                        if (marker1 == true && marker2 == false)
                        {
                            marker3 = true;

                        } else
                        {
                            Incorrect();
                        }
                        break;

                    default:
                        break;
                }
            }

        }

        if (marker1 && marker2 && marker3)
        {
            DisplayClue(); 
        }
    }

    void DisplayClue()
    {
        clue.SetActive(true);
        virusArea.SetActive(true);
        virusArea.GetComponent<Renderer>().enabled = true;

    }

    void Incorrect()
    {
        cube1.SetActive(true);
        cube2.SetActive(true);
        cube3.SetActive(true);

        marker1 = false;    
        marker2 = false;
        marker3 = false;

    }
}

