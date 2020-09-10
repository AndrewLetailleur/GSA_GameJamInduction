using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericStats : MonoBehaviour
{
    //basic stats for sort of all living stuff

    public float maxHealth;
    
    public float currentHealth;

    public float speed;

    public float jumpHeight;    
    
    
    
    public float baseDamage;

    [SerializeField] private GameObject _healthBar;

    private void Awake() {
        currentHealth = maxHealth;
        
    }


    

    
    
    private void Update() {
        if(_healthBar != null){
            _healthBar.GetComponent<HealthBar>().ReScaleBar(currentHealth/maxHealth);

        }
    }

    
}
