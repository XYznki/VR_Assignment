using UnityEngine;

public class OrbitRenderer : MonoBehaviour
{
    public Material orbitMaterial;
    public GameObject[] planets;
    public GameObject sun;
    public int numPoints = 100;
    public float lineWidth = 0.1f;

    private LineRenderer[] lineRenderers;

    void Start()
    {
        lineRenderers = new LineRenderer[planets.Length];
        for (int i = 0; i < planets.Length; i++)
        {
            lineRenderers[i] = planets[i].AddComponent<LineRenderer>();
            lineRenderers[i].positionCount = numPoints;
            lineRenderers[i].startWidth = lineWidth;
            lineRenderers[i].endWidth = lineWidth;
            lineRenderers[i].material = orbitMaterial;
        }
    }

    void Update()
    {
        for (int i = 0; i < planets.Length; i++)
        {
            Vector3[] positions = new Vector3[numPoints];
            float orbitRadius = Vector3.Distance(planets[i].transform.position, sun.transform.position);
            for (int j = 0; j < numPoints; j++)
            {
                float angle = j * Mathf.PI * 2f / numPoints;
                Vector3 pos = new Vector3(Mathf.Sin(angle), 0f, Mathf.Cos(angle)) * orbitRadius;
                Quaternion rotation = Quaternion.LookRotation(planets[i].transform.position - sun.transform.position);
                pos = rotation * pos;
                pos += sun.transform.position;
                positions[j] = pos;
            }
            lineRenderers[i].SetPositions(positions);
        }
    }
}
