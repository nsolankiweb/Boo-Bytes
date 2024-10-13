using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    [SerializeField] GameObject selectedObject;

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        selectedObject.SetActive(true);
    }
}
