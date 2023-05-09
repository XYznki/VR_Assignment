using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSelection : MonoBehaviour
{
    public GameObject lockOnHUD;
    private RaycastHit hit;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.CompareTag("Planet"))
            {
                lockOnHUD.SetActive(true);
            }
            else
            {
                lockOnHUD.SetActive(false);
            }
        }
        else 
        {
            lockOnHUD.SetActive(false);
        }
    }
}
