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

    [SerializeField] private GameObject gameStart; 

    [SerializeField] private GameObject UIG;
    [SerializeField] private GameObject UIP;

    private int hits = 0; 

    // Start is called before the first frame update
    void Start()
    {
        timer.enabled = false;
        clues.SetActive(false);
        intro.SetActive(true);
        UIP.SetActive(false); 
        UIG.SetActive(false);
        gameStart.SetActive(false);
    }


    public void PosterFound()
    {
        clues.SetActive(true);
        hits++; 
        if (hits == 1)
        {
            gameStart.SetActive(true);
        }
    }

    public void TimerStart()
    {
        timer.enabled = true;
    }

    public void Intro()
    {
        intro.SetActive(false);
    }
}
