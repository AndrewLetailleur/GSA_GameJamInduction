using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Transform bar;

    private void Start() {
        bar = transform.GetChild(0).GetChild(0);
    }
   public void ReScaleBar(float healthPercent){
       bar.localScale = new Vector2(healthPercent, 1f);
   }
}
