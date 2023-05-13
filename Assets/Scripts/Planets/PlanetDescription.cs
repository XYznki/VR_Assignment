using UnityEngine;
using UnityEngine.UI;

public class PlanetDescription : MonoBehaviour
{
    public GameObject panel;
    public AudioSource audioSource;
    public Text panelText;
    
    public AudioClip enterAudioClip;
    public string planetName;

    private void Start()
    {
        panel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panelText.text = planetName;
            panel.SetActive(true);
            audioSource.clip = enterAudioClip;
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panel.SetActive(false);
            audioSource.Stop();
        }
    }
}
