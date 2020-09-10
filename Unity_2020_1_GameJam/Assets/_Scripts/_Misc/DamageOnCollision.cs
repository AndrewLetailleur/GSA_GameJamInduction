using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    private GenericStats _genericStats;
    private bool isTriggered;

    private void Start() {
        _genericStats = GameObject.Find("Player").GetComponent<GenericStats>();
        isTriggered = false;
    }
    void OnTriggerEnter2D(Collider2D other){

        if(other.tag == "Enemy" && isTriggered == false){
            other.GetComponent<Damager>().TakeDamage(_genericStats.baseDamage);
            isTriggered = true;
        }
    }
}
