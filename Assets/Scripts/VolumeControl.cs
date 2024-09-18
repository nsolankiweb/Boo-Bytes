using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Vuforia;


public class VolumeControl : MonoBehaviour
{

    private float initialRotation;
    bool found = false; 
   

    // Start is called before the first frame update
    void Start()
    {
        

    }


    // Update is called once per frame
    void Update()
    {   
        if (found)
        {
            float currentRotation = transform.eulerAngles.y;

            if (initialRotation + 5 < currentRotation)
            {
                AudioListener.volume += 0.1f;
                initialRotation = currentRotation;
            }

            if (initialRotation - 5 > currentRotation)
            {
                AudioListener.volume -= 0.1f;
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

