using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    [SerializeField]
    private GameObject clues;

    [SerializeField]
    private TextMeshProUGUI timer;

    [SerializeField]
    private GameObject intro; 


    // Start is called before the first frame update
    void Start()
    {
        timer.enabled = false;
        clues.SetActive(false);
        intro.SetActive(true);
    }


    public void PosterFound()
    {
        clues.SetActive(true);
        timer.enabled = true;
    }

    public void Intro()
    {
        intro.SetActive(false);
    }
}
