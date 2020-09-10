using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private AssignAbilitiyPrefabs _assignAbilityPrefabs;



    //Abilities Variables
    [SerializeField] private float _jetPackJumpForce;
    

    

    //variables to customize abilities behaviours
    

    

    private void Awake() {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _assignAbilityPrefabs = GetComponent<AssignAbilitiyPrefabs>();
    }
    public void Jump(float jumpHeight){
        _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpHeight);

    }


    public void BasicAttack(){
        Instantiate(_assignAbilityPrefabs._basicAttackPrefab, transform.position, Quaternion.identity);
        
        

    }

    public void JetPackAbility(){
        _rigidbody2D.AddForce(new Vector2(0f, _jetPackJumpForce * Time.deltaTime), ForceMode2D.Force);
        
    }

   
}
