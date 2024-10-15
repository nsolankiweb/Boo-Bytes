using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for pit trigger enter 

public class ColliderScript : MonoBehaviour
{
    [SerializeField] GameObject selectedObject;

    void Start()
    {
        
        selectedObject.SetActive(false);
       
    }

    private void OnTriggerEnter(Collider other)
    {
        selectedObject.SetActive(true);
    }
}
