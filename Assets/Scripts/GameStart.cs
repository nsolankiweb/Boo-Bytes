using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField]
    private GameObject clues; 

    // Start is called before the first frame update
    void Start()
    {
        clues.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PosterFound()
    {
        clues.SetActive(true);
    }
}
