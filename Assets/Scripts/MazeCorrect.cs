using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCorrect : MonoBehaviour
{
    [SerializeField] private GameObject previousTile; 
    [SerializeField] private GameObject nextTile;
    [SerializeField] private Canvas inncorrect; 
    [SerializeField] private Canvas correct;

    bool hit = false; 

    // Start is called before the first frame update
    void Start()
    {
        
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
                correct.enabled = true;

            }
            else
            {
                inncorrect.enabled = true;
            }
        }
        
    }

}
