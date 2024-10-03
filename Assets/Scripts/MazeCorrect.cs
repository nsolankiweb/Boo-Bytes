using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCorrect : MonoBehaviour
{
    [SerializeField] private GameObject previousTile; 
    [SerializeField] private GameObject nextTile;
    [SerializeField] private Canvas inncorrect; 
    [SerializeField] private Canvas correct;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(previousTile.CompareTag("MazeTrue") && nextTile.CompareTag("MazeFalse"))
        {
            transform.gameObject.tag = "MazeTrue"; 
            correct.enabled = true;

        } else
        {
            inncorrect.enabled = true; 
        }
    }

}
