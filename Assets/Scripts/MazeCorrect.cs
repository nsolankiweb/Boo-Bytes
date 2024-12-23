using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCorrect : MonoBehaviour
{
    [SerializeField] private GameObject previousTile; 
    [SerializeField] private GameObject nextTile;
    [SerializeField] private Canvas inncorrect; 
    [SerializeField] private Canvas correct;
    [SerializeField] private GameObject sfxSource;
    private AudioSource sfx; 
    bool hit = false;

    private void Start()
    {
        sfx = sfxSource.GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.gameObject.CompareTag("MazeTrue"))
        {
            hit = true; 
        }
        else
        {
            hit = false; 
        }
    }

    private void OnTriggerEnter(Collider other)
    {   
        if(!hit)
        {
            Debug.Log("Correct hit");
            if (previousTile.CompareTag("MazeTrue") && nextTile.CompareTag("MazeFalse"))
            {
                transform.gameObject.tag = "MazeTrue";
                sfx.Play(); 
                //correct.enabled = true;

            }
            else
            {   
                //sound
                inncorrect.enabled = true;
            }
        }
        
    }

}
