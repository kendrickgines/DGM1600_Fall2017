using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	// Use this for initialization
	public Transform player;
	public Transform chicken;
	public Transform wolf;
	public Transform target;
	public GameObject pcHealth;
	public int damage;
	// public float distance;
	public float wolfSpeed = 10;
	
	void Start () {
		player = GameObject.FindWithTag("Player").transform;
		chicken = GameObject.FindWithTag("Chicken").transform;
		wolf = GameObject.FindWithTag("Wolf").transform;
		// distance = Vector3.Distance(chicken.position, player.position);

	}

	void Update() {
		transform.Translate(Vector3.forward * wolfSpeed * Time.deltaTime);
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

	void OnCollisionEnter(Collision other)
	{
		

		if(other.gameObject.tag == "Player"){
			var hit = other.gameObject;
			var health = hit.GetComponent<PlayerHealth>();
			
			if(pcHealth != null){

				pcHealth.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);

			}
		}
	}

}
