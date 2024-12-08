using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitInteraction : MonoBehaviour
{
    private int numPlatforms = 0;
    private int platformsTouched = 0;
    [SerializeField] private GameObject clue;
    [SerializeField] private GameObject virus;
    [SerializeField] private GameObject fail;
    [SerializeField] private GameObject virusArea;
    [SerializeField] private GameObject pit;
    [SerializeField] private GameObject UI;

    private float pitTime = 0f;
    private float maxTime = 2f; 

    void Start()
    {
        clue.SetActive(false);
        fail.SetActive(false);   
        virusArea.SetActive(false);
        Debug.Log("PIT HIT");
        UI.SetActive(false);

    }

   
    void Update()
    {
        //numPlatforms = GameObject.FindGameObjectsWithTag("Platform").Length; 
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            //platformsTouched++;
            pitTime = 0f; 
        
        }else if (other.CompareTag("PitFall")){
            
            pitTime += Time.deltaTime;
            if (pitTime > maxTime)
            {
                PitFail(); 
            }
        }

        if (other.CompareTag("PitExit"))
        {

            clue.SetActive(true);
            virusArea.SetActive(true);
            virusArea.GetComponent<Renderer>().enabled = true;

            pit.SetActive(false);
        }
    }

    private void PitFail()
    {
        pit.SetActive(false);
        fail.SetActive(true);
        virus.tag = "Respawn"; 

    }

}

