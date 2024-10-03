using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MazeFunctions : MonoBehaviour
{
    [SerializeField]
    private GameObject mainVirus;

    [SerializeField]
    private Canvas winning;

    [SerializeField]
    private Canvas losing;

    [SerializeField] private Canvas notcorrect;
    [SerializeField] private Canvas correct;

    [SerializeField] private GameObject A1; 
    [SerializeField] private GameObject A2;
    [SerializeField] private GameObject A3;
    [SerializeField] private GameObject B1;
    [SerializeField] private GameObject B2;
    [SerializeField] private GameObject B3;
    [SerializeField] private GameObject C3; 
    [SerializeField] private GameObject C4;

    public int inncorrect = 0;

    // Start is called before the first frame update
    void Start()
    {
        winning.enabled = false;
        losing.enabled = false;
        notcorrect.enabled = false;
        correct.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (A1.CompareTag("MazeTrue") && A2.CompareTag("MazeTrue") && A3.CompareTag("MazeTrue") &&
            B1.CompareTag("MazeTrue") && B2.CompareTag("MazeTrue") && B3.CompareTag("MazeTrue") &&
            C3.CompareTag("MazeTrue") && C4.CompareTag("MazeTrue"))
        {
            mainVirus.SetActive(true);
            transform.gameObject.SetActive(false);
        }

        
    }

    public void CheckIncorrect()
    {
        if (inncorrect == 3)
        {
            losing.enabled = true;
            transform.gameObject.SetActive(false);
        }
    }

    public void ResetMaze()
    {
        notcorrect.enabled = false;

        inncorrect++;
        CheckIncorrect();

        A1.tag = "MazeFalse";
        A2.tag = "MazeFalse";
        A3.tag = "MazeFalse";
        B1.tag = "MazeFalse";
        B2.tag = "MazeFalse";
        B3.tag = "MazeFalse";
        C3.tag = "MazeFalse";
        C4.tag = "MazeFalse";

         
    }

    public void ContinueMaze()
    {
        correct.enabled = false;
    }

}
