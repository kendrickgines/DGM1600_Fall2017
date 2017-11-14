using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Wander : MonoBehaviour {

	// Use this for initialization
	public float moveSpeed;
	public float directionChangeSpeed;

	void MoveForward(){
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}

	void SlowTurn(){
		float randomNum = (Random.Range(358,2) * Time.deltaTime);
		transform.Rotate(0,randomNum,0);
	}
	void Turn(){
		float randomNum = (Random.Range(0,360) * Time.deltaTime);
		transform.Rotate(0,randomNum,0);
	}

	void TurnAround(){
		float turnNum = (Random.Range(160,180) * Time.deltaTime);
		transform.Rotate(0,turnNum,0);
	}

	void OnTriggerStay(Collider other){
		if(other.gameObject.tag == "Ground"){
			MoveForward();
		}
		

			
		
	}
	void OnTriggerExit(Collider other){
		if(other.gameObject.tag == "Checkpoint"){
			TurnAround();
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Wall"){
			Turn();
	}

	}
}
