using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour
{
    Quaternion iniRot;

    public void Start()
    {
        iniRot = transform.rotation;
    }

    public void LateUpdate()
    {
        transform.rotation = iniRot;
    }
}
