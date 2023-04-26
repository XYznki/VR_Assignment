using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    public Transform planet;
    public float distance = 5f;
    public float damping = 0.5f;
    public float height = 5f;

    private Vector3 velocity = Vector3.zero;


    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPos = planet.position + Vector3.up * height - planet.forward * distance;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, damping);
        transform.LookAt(planet);
    }
}
