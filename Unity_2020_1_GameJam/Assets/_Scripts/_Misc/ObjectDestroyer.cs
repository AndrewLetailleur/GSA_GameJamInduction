using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField] private float _timeToDestroy = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyerTimer());
    }

    IEnumerator DestroyerTimer(){
        yield return new WaitForSeconds(_timeToDestroy);
        Destroy(this.gameObject);
    }

}
