using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempVirus : MonoBehaviour
{
    [SerializeField] GameObject CaughtSFX;
    public void OnTriggerEnter(Collider other)
    {
        transform.gameObject.tag = "Caught";
        CaughtSFX.SetActive(true);
    }
}
