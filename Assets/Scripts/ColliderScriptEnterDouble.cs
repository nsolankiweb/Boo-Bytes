using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for pit trigger enter 

public class ColliderScriptDouble : MonoBehaviour
{
    [SerializeField] GameObject selectedObject1;
    [SerializeField] GameObject selectedObject2;

    void Start()
    {
        
        selectedObject1.SetActive(false);
        selectedObject2.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        selectedObject1.SetActive(true);
        selectedObject2.SetActive(true);
    }
}
