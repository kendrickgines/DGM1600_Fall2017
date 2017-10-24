using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	// Use this for initialization
	public Transform player;
	public Transform chicken;
	public Transform wolf;
	public Transform target;
	// public float distance;
	public float wolfSpeed = 10;
	void Start () {
		player = GameObject.FindWithTag("Player").transform;
		chicken = GameObject.FindWithTag("Chicken").transform;
		wolf = GameObject.FindWithTag("Wolf").transform;
		// distance = Vector3.Distance(chicken.position, player.position);

	}

	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){
			Debug.Log("Player enters Wolf's trigger.");
			transform.LookAt(player);
			transform.Translate(Vector3.forward * wolfSpeed * Time.deltaTime);
		}
		else if(other.gameObject.name == "Chicken"){
			Debug.Log("Chicken Enters Wolf's trigger.");
			transform.LookAt(chicken);
			transform.Translate(Vector3.forward * wolfSpeed * Time.deltaTime);
		}
	}

}
