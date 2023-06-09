using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActiveUI : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2;
    public GameObject menu;
    public InputActionProperty showButton;
    // Start is called before the first frame update
    private Camera _cam;

    private void Start()
    {
        _cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
            menu.transform.position = head.position + new Vector3(head.forward.x, 1, head.forward.z).normalized * spawnDistance;
            menu.transform.rotation = Quaternion.LookRotation(menu.transform.position - _cam.transform.position);
            //menu.transform.rotation = Quaternion.LookRotation(menu.transform.position - head.position, Vector3.up);
        }
    }
}
