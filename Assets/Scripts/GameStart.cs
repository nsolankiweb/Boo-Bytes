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

    [SerializeField] private GameObject UIG;
    [SerializeField] private GameObject UIP; 


    // Start is called before the first frame update
    void Start()
    {
        timer.enabled = false;
        clues.SetActive(false);
        intro.SetActive(true);
        UIP.SetActive(false); 
        UIG.SetActive(false);
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
