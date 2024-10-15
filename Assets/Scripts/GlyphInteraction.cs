using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the puzzle 2 script. 

public class GlyphInteraction : MonoBehaviour
{

    [SerializeField]
    private GameObject clue;


    [SerializeField]
    private GameObject cube1;
    [SerializeField]
    private GameObject cube2;
    [SerializeField]
    private GameObject cube3;
    [SerializeField]
    private GameObject cube4;

    [SerializeField]
    private GameObject virusArea;

    private string hitName;

    private bool marker1 = false;
    private bool marker2 = false;
    private bool marker3 = false;
    private bool marker4 = false;

    void Start()
    {
        clue.SetActive(false); 
        virusArea.SetActive(false);
        cube1.SetActive(false);
        cube2.SetActive(false);
        cube3.SetActive(false);
        cube4.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))
            {
                hitName = Hit.transform.name;

                switch (hitName)
                {
                    case "Cylinder1":
                        cube1.SetActive(true);
                        if (marker2 ||  marker3 || marker4)
                        {
                            Incorrect(); 

                        } else
                        {
                            marker1 = true;
                        }
                        break;

                    case "Cylinder2":
                        cube2.SetActive(true);
                        if (marker1 && marker3 == false && marker4 == false)
                        {
                            marker2 = true;
                        }
                        else
                        {
                            Incorrect(); 
                        }
                        break;

                    case "Cylinder3":
                        cube3.SetActive(true);
                        if (marker1 && marker2 && marker3 == false)
                        {
                            marker3 = true;

                        } else
                        {
                            Incorrect();
                        }
                        break;

                    case "Cylinder4":
                        cube4.SetActive(true);
                        if (marker1 && marker2 && marker3)
                        {
                            marker4 = true;

                        }
                        else
                        {
                            Incorrect();
                        }
                        break;

                    default:
                        break;
                }
            }

        }

        if (marker1 && marker2 && marker3 && marker4)
        {
            DisplayClue();
        }
    }

    private void DisplayClue()
    {
        clue.SetActive(true);
        virusArea.SetActive(true);
        virusArea.GetComponent<Renderer>().enabled = true;

    }

    private void Incorrect()
    {
        cube1.SetActive(false);
        cube2.SetActive(false);
        cube3.SetActive(false);
        cube4.SetActive(false);

        marker1 = false;    
        marker2 = false;
        marker3 = false;
        marker4 = false;

    }
}

