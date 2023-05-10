using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabClone : MonoBehaviour
{
    public GameObject original;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clone()
    {
       // Instantiate(gameObject);
        Instantiate(gameObject);
        original.transform.localScale = gameObject.transform.localScale * 0.001f;


    }

    public void DestroyThing()
    {
        Destroy(gameObject);
    }



}
