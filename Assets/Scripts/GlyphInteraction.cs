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

    [SerializeField] private GameObject line1;
    [SerializeField] private GameObject line2;
    [SerializeField] private GameObject line3;

    private AudioSource ErrorSFX;
    [SerializeField] public GameObject audioObjectError;

    private AudioSource CorrectSFX;
    [SerializeField] public GameObject audioObjectCorrect;

    private string hitName;

    private bool marker1 = false;
    private bool marker2 = false;
    private bool marker3 = false;
    private bool marker4 = false;

    void Start()
    {
        clue.SetActive(false); 
        cube1.SetActive(false);
        cube2.SetActive(false);
        cube3.SetActive(false);
        cube4.SetActive(false);
        line1.SetActive(false);
        line2.SetActive(false);
        line3.SetActive(false);
        ErrorSFX = audioObjectError.GetComponent<AudioSource>();
        CorrectSFX = audioObjectCorrect.GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        //(Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(0).phase == TouchPhase.Stationary || Input.GetTouch(0).phase == TouchPhase.Began)
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))
            {
                hitName = Hit.transform.name;

                switch (hitName)
                {
                    case "CY1":
                        
                        if (marker2 ||  marker3 || marker4)
                        {
                            Incorrect(); 

                        } else
                        {
                            marker1 = true;
                            cube1.SetActive(true);
                            CorrectSFX.Play();
                        }
                        break;

                    case "CY2":
                        
                        if (marker1 && marker3 == false && marker4 == false)
                        {
                            marker2 = true;
                    
                            cube2.SetActive(true);
                            CorrectSFX.Play();
                            line1.SetActive(true);
                        }
                        else
                        {
                            Incorrect(); 
                        }
                        break;

                    case "CY3":
                        
                        if (marker1 && marker2 && marker3 == false)
                        {
                            marker3 = true;
                            
                            cube3.SetActive(true);
                            CorrectSFX.Play();
                            line2.SetActive(true);

                        } else
                        {
                            Incorrect();
                        }
                        break;

                    case "CY4":
                       
                        if (marker1 && marker2 && marker3)
                        {
                            marker4 = true;
                            
                            cube4.SetActive(true);
                            CorrectSFX.Play();
                            line3.SetActive(true);

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
        this.gameObject.tag = "Solved"; 

    }

    private void Incorrect()
    {
        ErrorSFX.Play();
        cube1.SetActive(false);
        cube2.SetActive(false);
        cube3.SetActive(false);
        cube4.SetActive(false);
        //line1.SetActive(false);
        //line2.SetActive(false);
        //line3.SetActive(false); 

        marker1 = false;    
        marker2 = false;
        marker3 = false;
        marker4 = false;

    }
}

