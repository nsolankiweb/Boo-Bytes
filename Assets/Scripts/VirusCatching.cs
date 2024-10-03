using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
//This script is for catching the virus. 

public class VirusCatching : MonoBehaviour
{
    [SerializeField] private Image v1;
    [SerializeField] private Image v2;
    [SerializeField] private Image v3;
    [SerializeField] private Image v4;
    [SerializeField] private Image v5;

    [SerializeField] private GameObject Virus1;
    private bool v1caught = false;

    [SerializeField] private GameObject FinalVirus;

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
                        v1.enabled = true;
                        Virus1.SetActive(false);
                        break;

                    case "FinalVirus":
                        FinalVirus.SetActive(false);
                        v5.enabled = true;
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
