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

    [SerializeField]
    private GameObject arElements; 


    void Start()
    {
        arCamera = GetComponent<VuforiaBehaviour>();
        var triggerAreas = GameObject.FindGameObjectsWithTag("TriggerArea");
        foreach (var triggerArea in triggerAreas)
        {
            triggerArea.GetComponent<Renderer>().enabled = false;
        }

    }

    void Update()
    {

    }

    public void ARCameraController()
    {
        

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

        arElements.SetActive(isOnAR);


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
