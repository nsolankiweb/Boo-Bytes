using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is for catching the virus. 

public class VirusCatching : MonoBehaviour
{
    [SerializeField]
    private GameObject Virus1;

    private bool v1caught = false;

    [SerializeField]
    private GameObject FinalVirus;
    [SerializeField] private Canvas winning; 

    [SerializeField]
    private GameObject Maze; 

    string hitName;

    // Start is called before the first frame update
    void Start()
    {
        Maze.SetActive(false);
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
                    case "Virus1":
                        v1caught = true; 
                        Virus1.SetActive(false);
                        break;

                    case "FinalVirus":
                        FinalVirus.SetActive(false);
                        winning.enabled = true; 
                        break;

                    default:
                        break;
                }
            }

        }

        if(v1caught)
        {
            Maze.SetActive(true); 
        }
    }
}
