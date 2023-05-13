using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class MenuManagerActive : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2;
    public GameObject menu,setting,gallery;
    public InputActionProperty showButton;

    private Camera _cam;

    private void Start()
    {
        _cam = Camera.main;
    }

    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {

            menu.SetActive(!menu.activeSelf);
            menu.transform.position = head.position + new Vector3(head.forward.x, 1, head.forward.z).normalized * spawnDistance;
            menu.transform.rotation = Quaternion.LookRotation(menu.transform.position - _cam.transform.position);
            //menu.transform.rotation = Quaternion.LookRotation(menu.transform.position - head.position, Vector3.up);

            setting.transform.position = menu.transform.position;
            setting.transform.rotation = menu.transform.rotation;

            gallery.transform.position=menu.transform.position;
            gallery.transform.rotation=menu.transform.rotation;
        }
    }
}

