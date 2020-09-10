using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviours : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private MouseHandler _mouseHandler;
    private Vector3 _mouseDir;

    [SerializeField] private float _projectileSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _mouseHandler = GameObject.Find("Player").GetComponent<MouseHandler>();
        _mouseDir = _mouseHandler._mouseDirection;
    }

    // Update is called once per frame
    void Update()
    {
        MoveStraightToMouseDir();
    }

    void MoveStraightToMouseDir(){
        if(_rigidbody2D != null){
            _rigidbody2D.velocity = new Vector2(_mouseDir.x, _mouseDir.y).normalized * _projectileSpeed;
        }
        
        
    }
}
