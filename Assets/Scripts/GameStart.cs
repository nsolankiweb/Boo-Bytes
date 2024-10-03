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


    // Start is called before the first frame update
    void Start()
    {
        timer.enabled = false;
        clues.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PosterFound()
    {
        clues.SetActive(true);
        timer.enabled = true;
    }
}
