using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
