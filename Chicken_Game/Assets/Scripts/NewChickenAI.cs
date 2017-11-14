using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewChickenAI : MonoBehaviour {


public float speed;
public Transform chicken;
public Transform player;
public Transform wolf;
public Transform chickenPen;

	void Awake(){
		
		
	}

void Start () {
		player = GameObject.FindWithTag("Player").transform;
		wolf = GameObject.FindWithTag("Wolf").transform;
		chickenPen = GameObject.FindWithTag("ChickenPen").transform;
		chicken = GameObject.FindWithTag("Chicken").transform;

		float randomNum = (Random.Range(0,360) * Time.deltaTime);
		transform.Rotate(0,randomNum,0);
	}
	
	void OnTriggerStay(Collider other){

		if(other.gameObject.tag == "Player"){
			Debug.Log("Player enters Chicken's trigger.");
			transform.LookAt(player);
			transform.Rotate(0,180,0);
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
		else if(other.gameObject.tag == "Wolf"){
			Debug.Log("Wolf Enters Chicken's trigger.");
			transform.LookAt(wolf);
			transform.Rotate(0,180,0);
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
		else if(other.gameObject.tag == "Ground"){
			
		}
	}
	
	void OnCollisionEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			chicken.position = chickenPen.position;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
