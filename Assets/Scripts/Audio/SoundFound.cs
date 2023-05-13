using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFound : MonoBehaviour
{

    public AudioSource audioSource;
    public GameObject requiredObject;
    private bool hasPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySoundIfObjectActive()
    {
        if (requiredObject.activeSelf && !hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;
        }
    }
}


