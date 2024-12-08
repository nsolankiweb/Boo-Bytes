using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempVirus : MonoBehaviour
{
    [SerializeField] GameObject CaughtSFX;
    [SerializeField] GameObject CaughtUI;
    [SerializeField] GameObject MazeClue;

    private void Start()
    {
        CaughtUI.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {

        transform.gameObject.tag = "Caught";
        CaughtSFX.GetComponent<AudioSource>().Play();
        CaughtUI.SetActive(true);
        MazeClue.SetActive(true);
    }
}
