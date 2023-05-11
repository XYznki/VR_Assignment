using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyTowardsPlanet : MonoBehaviour
{
    public Transform destination;
    public float flySpeed = 10f;

    public Vector3 targetPosition;
    private float distance;
    private float startTime;
    private bool isMoving = false;

    void Start()
    {
        targetPosition = destination.position;
        distance = Vector3.Distance(transform.position, targetPosition);
    }

    void Update()
    {
        if(isMoving)
        {
            float distCovered = (Time.time - startTime) / flySpeed;
            float fractionOfJourney = distCovered/ distance;
            transform.position = Vector3.Lerp(transform.position,targetPosition,fractionOfJourney);

            if(fractionOfJourney >= 1f)
            {
                isMoving = false;
            }

        }
    }

    public void StartMovement()
    {
        isMoving = true;
        startTime = Time.time;
    }
}
