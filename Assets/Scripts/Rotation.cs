using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * 10);
        transform.Rotate(Vector3.up * Time.deltaTime * 10, Space.World);
    }
}
