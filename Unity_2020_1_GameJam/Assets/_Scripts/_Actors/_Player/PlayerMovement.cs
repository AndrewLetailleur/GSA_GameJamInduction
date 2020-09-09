using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private GenericStats _genericStats;

    //[SerializeField] private KeyCode _jumpKey;  //keyboard key to change from the inspector

    

    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _genericStats = GetComponent<GenericStats>();
    }

    private void Update() {


        /*if(Input.GetKeyDown(_jumpKey)){
            PlayerJump();
        }*/

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMovementController();

        
    }


    void PlayerMovementController(){
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        if(_rigidbody2D != null){
            _rigidbody2D.velocity = new Vector2((horizontalInput * _genericStats.speed * Time.deltaTime), _rigidbody2D.velocity.y);
        }
        
    }

    void PlayerJump(){
        
    }
}
