using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is for the trigger area collisions. 

public class VirusTriggerArea : MonoBehaviour
{   
    //if you have more objects add more. 
    [SerializeField] GameObject Virus; 

    void Start()
    {
        transform.gameObject.SetActive(false);

        //if you have more objects. Set them to false/ 
        Virus.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {   
        //if you have more objects set them to true. 
        Virus.SetActive(true); 
    }



}
