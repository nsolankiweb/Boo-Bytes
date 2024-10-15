using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Vuforia;

//This script controlls the volume.
public class VolumeControl : MonoBehaviour
{

    private float initialRotation;
    bool found = false; 
   

    // Update is called once per frame
    void Update()
    {   
        if (found)
        {
            float currentRotation = transform.eulerAngles.y;

            if (initialRotation + 5 < currentRotation)
            {
                AudioListener.volume += 0.25f;
                initialRotation = currentRotation;
            }

            if (initialRotation - 5 > currentRotation)
            {
                AudioListener.volume -= 0.25f;
                initialRotation = currentRotation;
            }
            
        }
    }

    public void setStartingAngle()
    {
        initialRotation = transform.eulerAngles.y;
        found = true;
    }
}

