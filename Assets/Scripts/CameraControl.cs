using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class CameraControl : MonoBehaviour
{
    bool isOn = true;
    private VuforiaBehaviour arCamera; 

    void Start()
    {
        arCamera = GetComponent<VuforiaBehaviour>();
    }

    void Update()
    {
        
    }

    public void ARCameraController()
    {
        var imageTargets = FindObjectsOfType<ImageTargetBehaviour>(); 

        if (isOn)
        {
            isOn = false;
        }
        else
        { 
            isOn = true;
        }

        foreach (var imageTarget in imageTargets)
        {
            imageTarget.enabled = isOn; 
        }
    }
}
