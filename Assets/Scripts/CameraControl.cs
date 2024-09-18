using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    bool isOn = true;
    private VuforiaBehaviour arCamera; 
    void Start()
    {
        arCamera = GetComponent<VuforiaBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ARCameraController()
    {
        var imageTargets = FindObjectsOfType<ImageTargetBehaviour>(); 

        if (isOn)
        {
            //arCamera.enabled = false;
            isOn = false;
        }
        else
        {
            //arCamera.enabled = true;
            isOn = true;
        }

        foreach (var imageTarget in imageTargets)
        {
            imageTarget.enabled = isOn; 
        }
    }
}
