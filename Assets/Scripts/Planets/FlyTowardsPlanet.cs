using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyTowardsPlanet : MonoBehaviour
{
    public Transform planet;
    public float planetdistance = 5f;
    public float damping = 0.5f;
    public float height = 5f;

    private Vector3 velocity = Vector3.zero;
    public float flySpeed = 10f;

    public Vector3 targetPosition;
    private float startTime;
    private bool isMoving = false;


    void Update()
    {
        if (isMoving)
        {
            //transform.position = destination.position;
            //float distCovered = (Time.time - startTime) / flySpeed;
            //float fractionOfJourney = 5 / distance;
            transform.position = Vector3.Lerp(transform.position, targetPosition, 0.01f);

            Vector3 targetPos = planet.position + Vector3.up * height - planet.forward * planetdistance;
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, damping);
            //transform.LookAt(planet);

            //if (fractionOfJourney >= 1f)
            //{
            //    isMoving = false;
            //}

        }
    }

    public void StartMovement(Transform planet)
    {
        this.planet = planet;
        isMoving = true;
        startTime = Time.time;
    }

    public void StopMovement()
    {
        isMoving = false;
    }

    
}