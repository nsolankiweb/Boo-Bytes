using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeIncorrect : MonoBehaviour
{
    [SerializeField] private Canvas inncorrect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        inncorrect.enabled = true;
        Debug.Log("Incorrect hit");
        
    }
}
