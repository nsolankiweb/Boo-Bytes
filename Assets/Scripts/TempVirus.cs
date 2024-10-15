using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempVirus : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        transform.gameObject.tag = "Caught"; 
    }
}
