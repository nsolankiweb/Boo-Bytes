using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneAlignment : MonoBehaviour
{
    [SerializeField] GameObject environment;
    [SerializeField] GameObject otherParent;

    private Vector3 startPos;
    private Quaternion startRos; 
    
    private int hits = 0; 
    // Start is called before the first frame update
    void Start()
    {
        startPos = environment.transform.localPosition;
        startRos = environment.transform.localRotation;

        var triggerAreas = GameObject.FindGameObjectsWithTag("TriggerArea");
        foreach (var triggerArea in triggerAreas)
        {
            triggerArea.GetComponent<Renderer>().enabled = false;
        }
    }


    public void Realign()
    {   
        hits++;
        var triggerAreas = GameObject.FindGameObjectsWithTag("TriggerArea");
        foreach (var triggerArea in triggerAreas)
        {
            triggerArea.GetComponent<Renderer>().enabled = false;
        }

        if (hits == 1)
        {
            environment.transform.SetParent(this.transform);

            environment.transform.localPosition = startPos;
            environment.transform.localRotation = startRos;

            environment.transform.SetParent(otherParent.transform);

        }

        environment.transform.SetParent(this.transform);

        environment.transform.localPosition = startPos;
        environment.transform.localRotation = startRos;

        environment.transform.SetParent(otherParent.transform);

    }
}
