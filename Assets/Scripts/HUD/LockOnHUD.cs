using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOnHUD : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayLockOnAnimation()
    {
        animator.SetTrigger("LockOn");
    }
}
