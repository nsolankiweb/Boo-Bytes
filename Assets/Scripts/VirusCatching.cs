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
    [SerializeField] private GameObject Virus1Area;
    private bool v1caught = false;

    [SerializeField] private GameObject Virus2;
    [SerializeField] private GameObject Virus2Area;
    private bool v2caught = false;

    [SerializeField] private GameObject Virus3;
    [SerializeField] private GameObject Virus3Area;
    private bool v3caught = false;

    [SerializeField] private GameObject FinalVirus;
    [SerializeField] private GameObject FinalVirusArea;

    [SerializeField] private Canvas winning;

    [SerializeField] private GameObject sfxSource;
    private AudioSource sfx;

    [SerializeField]
    private GameObject Maze; 

    string hitName;

    // Start is called before the first frame update
    void Start()
    {
        Maze.SetActive(false);

        v1.enabled = false;
        v2.enabled = false;
        v3.enabled = false;
        v4.enabled = false;
        v5.enabled = false;

        sfx = sfxSource.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        //    RaycastHit Hit;

        //    if (Physics.Raycast(ray, out Hit))
        //    {
        //        hitName = Hit.transform.name;


        //        switch (hitName)
        //        {
        //            case "Virus1Model":
        //                v1caught = true; 
        //                v1.enabled = true;
        //                Virus1.SetActive(false);
        //                break;

        //            case "FinalVirusModel":
        //                FinalVirus.SetActive(false);
        //                v5.enabled = true;
        //                winning.enabled = true; 
        //                break;

        //            default:
        //                break;
        //        }
        //    }

        //}

        if(Virus1.CompareTag("Caught"))
        {
            v1caught = true;
            v1.enabled = true;
            Virus1.SetActive(false);
            Virus1Area.SetActive(false);
            sfx.Play();

        }

        if (Virus2.CompareTag("Caught"))
        {
            v2caught = true;
            v2.enabled = true;
            Virus2.SetActive(false);
            Virus2Area.SetActive(false);

        }

        if (Virus3.CompareTag("Caught"))
        {
            v3caught = true;
            v3.enabled = true;
            Virus3.SetActive(false);
            Virus3Area.SetActive(false);
            sfx.Play();

        }

        if (FinalVirus.CompareTag("Caught"))
        {
            FinalVirus.SetActive(false);
            v4.enabled = true;
            winning.enabled = true;
            FinalVirusArea.SetActive(false);
            sfx.Play();
        }

        if (v1caught && v2caught && v3caught)
        {
            Maze.SetActive(true); 
        }
    }
}
