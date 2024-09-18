using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            Plane plane = new Plane(Vector3.up, transform.position);

            float distance = 0; 

            if (plane.Raycast(ray, out distance))
            { 
                Vector3 pos = ray.GetPoint(distance); 

                transform.position = pos;                                     
            }
        }
    }
}