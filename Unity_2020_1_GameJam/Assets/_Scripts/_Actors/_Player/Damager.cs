using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    private GenericStats _genericStats;

    private void Start() {
        _genericStats = GetComponent<GenericStats>();
    }

    private void Update() {
        KillObject();
    }
    
  public void TakeDamage(float damageReceived){
      _genericStats.currentHealth -= damageReceived;
  }

  void KillObject(){
      if(_genericStats.currentHealth < 1){
          Destroy(this.gameObject);
      }
  }

  
}
