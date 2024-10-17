using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeIncorrect : MonoBehaviour
{
    [SerializeField] private Canvas inncorrect;


    private void OnTriggerEnter(Collider other)
    {
        //sound here
        inncorrect.enabled = true;
        Debug.Log("Incorrect hit");
        
    }
}
