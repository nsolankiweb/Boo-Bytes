using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

//This script is the visablity controllers. 
public class CameraControl : MonoBehaviour
{
    bool isOnAR = true;
    bool isOnDebug = false;
    private VuforiaBehaviour arCamera;

    [SerializeField]
    private Sprite vision;

    [SerializeField]
    private Sprite noVision;

    [SerializeField]
    private Sprite nMode;

    [SerializeField]
    private Sprite dMode;

    [SerializeField]
    private Button arButton;

    [SerializeField]
    private Button debugButton;


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
            arButton.GetComponent<UnityEngine.UI.Image>().sprite = noVision;
        }
        else
        {
            isOnAR = true;
            arButton.GetComponent<UnityEngine.UI.Image>().sprite = vision;
        }

        foreach (var imageTarget in imageTargets)
        {
            imageTarget.enabled = isOnAR;
        }


    }

    public void DebugController()
    {
        var triggerAreas = GameObject.FindGameObjectsWithTag("TriggerArea");

        if (isOnDebug)
        {
            isOnDebug = false;
            debugButton.GetComponent<UnityEngine.UI.Image>().sprite = nMode;
        }
        else
        {

            isOnDebug = true;
            debugButton.GetComponent<UnityEngine.UI.Image>().sprite = dMode;
        }

        foreach (var triggerArea in triggerAreas)
        {
            triggerArea.GetComponent<Renderer>().enabled = isOnDebug;
        }

    }
}
