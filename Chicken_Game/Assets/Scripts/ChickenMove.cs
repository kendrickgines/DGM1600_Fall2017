using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : MonoBehaviour {

	public Transform player;
	public Transform wolf;
	// public Transform chicken;
	public Transform target;
	public Transform chickenPen;
	// public float distance;
	public float chickenSpeed = 7;
	public float directionChangeSpeed = 1;

	CharacterController controller;
	public float heading;
	public float maxHeadingChange;
	Vector3 targetRotation;



	void Awake (){
		controller = GetComponent<CharacterController>();
		heading = (Random.Range(0, 360));
		transform.eulerAngles = new Vector3(0, heading, 0);

		StartCoroutine(RandomWalkLoop());
	}

	void Start () {
		player = GameObject.FindWithTag("Player").transform;
		wolf = GameObject.FindWithTag("Wolf").transform;
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
			transform.LookAt(wolf);
			transform.Translate(Vector3.back * chickenSpeed * Time.deltaTime);
		}

	}
	
	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "Player"){
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		}
	}

	void Update () {
		
		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * chickenSpeed);
		var forward = transform.TransformDirection(Vector3.forward);
		controller.SimpleMove(forward * chickenSpeed);

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
	}
	IEnumerator RandomWalkLoop(){
			yield return new WaitForSeconds(directionChangeSpeed * Time.deltaTime);
		}

	void NewDirection(){
		var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
		var ceiling = Mathf.Clamp(heading + maxHeadingChange, 0, 360);
		heading = Random.Range(floor, ceiling);
		targetRotation = new Vector3(0, heading, 0);
	}

}
