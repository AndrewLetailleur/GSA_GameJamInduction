using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedEnemyAI : MonoBehaviour
{
   private enum State{
       roaming,
       attackTarget,
       backToStartPos,
   }
   private GenericStats _genericStats;
   [SerializeField] private Transform _target;

   private Vector3 _startPoint;
   [SerializeField] private State _state;

   //variables for control
   [SerializeField] private float _sightRange;
   [SerializeField] private float _keepDistance;

   [SerializeField] private bool isMovingRight;

   private void Start() {
       _genericStats = GetComponent<GenericStats>();
       _state = State.roaming;
       _startPoint = transform.position;
       InvokeRepeating("SwapBetweenDirection", 1, 2);
   }

   private void Update() {
       DistanceCheck();
       StateController();




       

       
   }


   void StateController(){
       switch(_state){
           case State.roaming:
                PatrolMovement();
                    break;

            case State.attackTarget:
                AgressiveIntance();
                    break;

            case State.backToStartPos:
                GoBackToStartPos();
                break;
       }
   }

   void PatrolMovement(){
       if(isMovingRight){
           transform.Translate(Vector2.left * _genericStats.speed * Time.deltaTime);
       }
       else if(!isMovingRight){
           transform.Translate(Vector2.right * _genericStats.speed * Time.deltaTime);

       }
       
       
   }

   void SwapBetweenDirection(){
       isMovingRight = !isMovingRight;
   }




    
   void DistanceCheck(){
       if (Vector3.Distance(transform.position, _target.position) < _sightRange){
           _state = State.attackTarget;
       }
       /*else
       {
           _state = State.roaming;
       }*/
   }


   void AgressiveIntance(){
       if(Vector3.Distance(transform.position, _target.position) < _sightRange && Vector3.Distance(transform.position, _target.position) > _keepDistance){
           transform.position = Vector3.MoveTowards(transform.position, _target.position, _genericStats.speed * Time.deltaTime);
       }

       if(Vector3.Distance(transform.position, _target.position) < _keepDistance){
           transform.position = Vector3.MoveTowards(transform.position, new Vector3(-(_target.position.x), -_target.position.y, 0f), _genericStats.speed * Time.deltaTime);

       }
       if(Vector3.Distance(transform.position, _target.position) > _sightRange){
           _state = State.backToStartPos;
       }
   }

   void GoBackToStartPos(){
       transform.position = Vector3.MoveTowards(transform.position, _startPoint, _genericStats.speed * Time.deltaTime);
       if(transform.position == _startPoint){
           _state = State.roaming;
       }
   }



   
}
