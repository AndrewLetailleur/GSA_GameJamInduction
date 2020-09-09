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

    private void Awake() {
        _playerAbilities = GetComponent<PlayerAbilities>();
        _genericStats = GetComponent<GenericStats>();
    }

    private void Update() {
        if(Input.GetKeyDown(_jumpKey)){
            _playerAbilities.Jump(_genericStats._jumpHeight);

        }


        if(Input.GetKeyDown(_basicAttackKey)){
            _playerAbilities.BasicAttack();
        }
    }
}
