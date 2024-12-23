using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI time;

    [SerializeField]
    private Canvas TimeOut;

    [SerializeField] private Canvas Win;

    [SerializeField]
    private GameObject coffee;

    [SerializeField]
    private GameObject ARE;

    public float remainingTime = 600; 


    void Start()
    {
        time.text = "00:00";
        //TimeOut.enabled = false;
    }


    void Update()
    {
        if (remainingTime > 0.9 && time.enabled == true)
        {
            remainingTime -= Time.deltaTime;

            float minutes = Mathf.FloorToInt(remainingTime / 60);

            float seconds = Mathf.FloorToInt(remainingTime % 60);

            time.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        if (remainingTime <= 0.9 && time.enabled == true)
        {
            TimeOut.enabled = true;
            coffee.SetActive(true);
            ARE.SetActive(false);
            time.enabled = false;

        }

        if(TimeOut.enabled == true || Win.enabled == true)
        {
            time.enabled = false;
        }

    }
}
