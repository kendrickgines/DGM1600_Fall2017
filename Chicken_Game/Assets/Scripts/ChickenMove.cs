using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : MonoBehaviour {

	public Transform player;
	// public Transform chicken;
	public Transform target;
	// public float distance;
	public float chickenSpeed = 7;
	void Start () {
		player = GameObject.FindWithTag("Player").transform;
		// chicken = GameObject.FindWithTag("Chicken").transform;
		// distance = Vector3.Distance(chicken.position, player.position);

	}

	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){
			Debug.Log("Player enters Chicken's trigger.");
			transform.LookAt(player);
			transform.Translate(Vector3.back * chickenSpeed * Time.deltaTime);
		}
		else if(other.gameObject.name == "Wolf"){
			Debug.Log("Wolf Enters Chicken's trigger.");
			transform.LookAt(target);
			transform.Translate(Vector3.back * chickenSpeed * Time.deltaTime);
		}
	}

	// void Update () {
		


		// if((distance<20)
		// && (distance>3)){
		// 	transform.LookAt (player);
		// 	transform.Translate (Vector3.forward * chickenSpeed *Time.deltaTime);
		// }
		// if((distance>20) || (distance<3)){

		// 	transform.Translate (Vector3.forward * 0);

		// }
		// else {
		// 	transform.Translate (Vector3.forward * 0);
		// }
// 	}
}
