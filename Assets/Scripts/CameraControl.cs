using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class CameraControl : MonoBehaviour
{
    bool isOnAR = true;
    bool isOnDebug = false;
    private VuforiaBehaviour arCamera;

    [SerializeField]
    private GameObject imageUI; 


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

        if (isOnAR)
        {
            isOnAR = false;
        }
        else
        { 
            isOnAR = true;
        }

        foreach (var imageTarget in imageTargets)
        {
            imageTarget.enabled = isOnAR; 
        }

        imageUI.SetActive(isOnAR);

    }

    public void debugController()
    {
        var triggerAreas = GameObject.FindGameObjectsWithTag("TriggerArea"); 

        if (isOnDebug)
        {
            isOnDebug = false;
        }
        else
        {
            isOnDebug = true;
        }

        foreach (var triggerArea in triggerAreas)
        {
            triggerArea.GetComponent<Renderer>().enabled = isOnDebug;
        }

    }
}
