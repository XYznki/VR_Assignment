using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiting : MonoBehaviour
{
    public float rotateSpeed;
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, Time.deltaTime * rotateSpeed);
    }
}
