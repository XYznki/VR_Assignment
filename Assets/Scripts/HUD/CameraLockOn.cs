using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLockOn : MonoBehaviour
{
    public LockOnHUD lockOnHUD;
    void Update()
    {
        if(Physics.Raycast(transform.position,transform.forward,out RaycastHit hit))
        { 
            if(hit.collider.CompareTag("Planet"))
            {
                lockOnHUD.PlayLockOnAnimation();
            }
        }
    }
}
