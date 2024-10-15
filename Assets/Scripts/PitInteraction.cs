using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitInteraction : MonoBehaviour
{
    private int numPlatforms = 0;
    private int platformsTouched = 0;
    [SerializeField] private GameObject clue;
    [SerializeField] private GameObject fail;
    [SerializeField] private GameObject virusArea;
    [SerializeField] private GameObject pit;

    void Start()
    {
        clue.SetActive(false);
        fail.SetActive(false);   
        virusArea.SetActive(false);

    }

   
    void Update()
    {
        numPlatforms = GameObject.FindGameObjectsWithTag("Platform").Length; 
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            platformsTouched++;
        
        }

        if (other.CompareTag("PitExit"))
        {
            if(platformsTouched > 0 && numPlatforms > 0)
            {
                clue.SetActive(true);
                virusArea.SetActive(true);
                virusArea.GetComponent<Renderer>().enabled = true;

            } else
            {
                fail.SetActive(true);
            }

            pit.SetActive(false);
        }
    }

    //public void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Platform"))
    //    {
    //        platformsTouched--;
    //    }
    //}
}

