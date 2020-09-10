using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotKeysController : MonoBehaviour
{
    private PlayerAbilities _playerAbilities;
    private GenericStats _genericStats;
   //Keys Variables
    [SerializeField] private KeyCode _jumpKey;
    [SerializeField] private KeyCode _basicAttackKey;

    [SerializeField] private KeyCode _jetPackKey;

    [SerializeField] private KeyCode _activateJumpModeKey;
    [SerializeField] private KeyCode _activateJetPackModeKey;

    private CapsuleCollider2D _capsuleCollider2D;
    [SerializeField] private LayerMask _groundLayerMask;


    //extra variables for limitations
    [SerializeField] private bool _jumpActive;
    [SerializeField] private bool _jetPackActive;
    


    
    

    private void Awake() {
        _playerAbilities = GetComponent<PlayerAbilities>();
        _genericStats = GetComponent<GenericStats>();
        _capsuleCollider2D = GetComponent<CapsuleCollider2D>();
        _jumpActive = true;
        _jetPackActive = false;
    }

    

    private void Update() {

        JumpModeSwap();

        if(_jumpActive){
            
            if(Input.GetKeyDown(_jumpKey) && IsGrounded()){
                _playerAbilities.Jump(_genericStats.jumpHeight);

        } 
        
        
    }               


        if(Input.GetKeyDown(_basicAttackKey)){
            _playerAbilities.BasicAttack();
        }


        if(_jetPackActive){
            if(Input.GetKey(_jetPackKey)){
            _playerAbilities.JetPackAbility();
            }

        } 

        

         

        

       
    }


    private bool IsGrounded(){
        float extraRayHeight = 0.1f;
        RaycastHit2D raycastHit = Physics2D.Raycast(_capsuleCollider2D.bounds.center, Vector2.down, _capsuleCollider2D.bounds.extents.y + extraRayHeight, _groundLayerMask);
        Color rayColor;
        if(raycastHit.collider != null){
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(_capsuleCollider2D.bounds.center, Vector2.down * (_capsuleCollider2D.bounds.extents.y + extraRayHeight));
        
        return raycastHit.collider != null;
    }


    private void JumpModeSwap(){
        if(Input.GetKeyDown(_activateJumpModeKey)){
            _jumpActive = true;
            _jetPackActive = false;
        }

        if(Input.GetKeyDown(_activateJetPackModeKey)){
            _jetPackActive = true;
            _jumpActive = false;
        }
    }

    
}
