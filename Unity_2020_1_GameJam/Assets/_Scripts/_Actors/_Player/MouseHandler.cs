using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHandler : MonoBehaviour
{
    private Camera _mainCam;

    public Vector3 _mousePosition;
    public Vector3 _mouseDirection;
    // Start is called before the first frame update
    void Awake()
    {
        _mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(_mainCam != null){
            _mousePosition = _mainCam.ScreenToWorldPoint(Input.mousePosition);
            _mouseDirection = _mousePosition - transform.position;
        }
        
    }
}
