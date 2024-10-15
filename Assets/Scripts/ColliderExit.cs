using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderExit : MonoBehaviour
{
    [SerializeField] GameObject selectedObject;

    private void OnTriggerEnter(Collider other)
    {
        selectedObject.SetActive(false);
    }
}
