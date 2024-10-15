using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeFirst : MonoBehaviour
{
    [SerializeField] private GameObject nextTile;
    [SerializeField] private Canvas inncorrect;
    [SerializeField] private Canvas correct;

    bool hit = false;


    // Update is called once per frame
    void Update()
    {
        if (transform.gameObject.CompareTag("MazeTrue"))
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
        if (!hit)
        {
            Debug.Log("First hit");
            if (nextTile.CompareTag("MazeFalse"))
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
