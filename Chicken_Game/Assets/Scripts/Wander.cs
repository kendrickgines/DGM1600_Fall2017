using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Wander : MonoBehaviour {

	// Use this for initialization
	public float moveSpeed;

	void MoveForward(){
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}

	void Turn(){
		int randomNum = Random.Range(0,360);
		transform.Rotate(0,randomNum,0);
	}

	void TurnAround(){
		int turnNum = Random.Range(160,180);
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
	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Wall"){
			Turn();
		}
	}

}
