using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueOneInteraction : MonoBehaviour
{

    [SerializeField]
    GameObject monster;

    [SerializeField]
    GameObject clueText;

    [SerializeField]
    GameObject cube1;
    [SerializeField]
    GameObject cube2;
    [SerializeField]
    GameObject cube3;
    [SerializeField]
    AudioSource sfx;


    // Start is called before the first frame update
    bool cube1s = false; 
    bool cube2s = false;
    bool cube3s = false;
    string hitName;

    void Start()
    {
        monster.SetActive(false);
        clueText.SetActive(false); 
        sfx.enabled = true;


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
                    case "Cube01":
                        cube1s = true;
                        cube1.SetActive(false);
                        sfx.Play();
                        break;

                    case "Cube02":
                        cube2s = true;
                        cube2.SetActive(false);
                        sfx.Play();
                        break;

                    case "Cube03":
                        cube3s = true;
                        cube3.SetActive(false);
                        sfx.Play();
                        break;
                    default:
                        break;
                }
            }

        }

        if (cube1s && cube2s && cube3s)
        {
            DisplayClue(); 
        }
    }

    void DisplayClue()
    {
        monster.SetActive(true);
        clueText.SetActive(true);

    }
}

