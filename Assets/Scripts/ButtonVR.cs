using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    //[SerializeField] private float threshold = 0.1f;
    //[SerializeField] private float deadZone = 0.025f;


    private Vector3 _startPos;
    private ConfigurableJoint _joint;

    //try
    public GameObject button;
    GameObject presser;
    public UnityEvent onPressed, onReleased;
    AudioSource sound;
    private bool _isPressed;


    // Start is called before the first frame update
    void Start()
    {
        //_startPos= transform.localPosition;
        //_joint=GetComponent<ConfigurableJoint>();

        sound= GetComponent<AudioSource>();
        _isPressed= false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(!_isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser=other.gameObject;
            onPressed.Invoke();
            sound.Play();
            _isPressed= true;
           
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject==presser)
        {
            button.transform.localPosition= new Vector3(0,0.015f,0);
            onReleased.Invoke();
            _isPressed = false;
            
        }
       
    }

    public void Success()
    {
        Debug.Log("DONE");
    }


    // Update is called once per frame
    void Update()
    {
      //if(!_isPressed&&GetValue()+threshold>=1)
      //  {
      //      Pressed();
      //  }
      //  if (!_isPressed && GetValue() - threshold <= 0)
      //  {
      //      Released();
      //  }

    }

    //private float GetValue()
    //{
    //    var value = Vector3.Distance(_startPos, transform.localPosition) / _joint.linearLimit.limit;

    //    if(Mathf.Abs(value) < deadZone)
    //    {
    //        value = 0;
    //    }
    //    return Mathf.Clamp(value, -1f, 1f);
    //}

    //private void Pressed()
    //{
    //    _isPressed= true;
    //    onPressed.Invoke();
    //    Debug.Log("Pressed");
    //}

    //private void Released()
    //{
    //    _isPressed= false;
    //    onReleased.Invoke();
    //    Debug.Log("Released");
    //}
}
