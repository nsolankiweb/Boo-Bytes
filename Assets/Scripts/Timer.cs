using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI time;

    public float remainingTime = 600; 


    void Start()
    {
        time.text = "00:00";
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

    }
}
