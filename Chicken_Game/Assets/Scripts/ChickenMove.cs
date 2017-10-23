using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : MonoBehaviour {

	public Transform player;
	public Transform chicken;
	public float distance;
	void Start () {
		player = GameObject.FindWithTag("Player").transform;
		chicken = GameObject.FindWithTag("Chicken").transform;
		distance = Vector3.Distance(chicken.position, player.position);
	}

	void Update () {
		
		if((distance<20)
		&& (distance>3)){
			transform.LookAt (player);
			transform.Translate (Vector3.forward * Time.deltaTime);
		}
		if((distance>20) || (distance<3)){

			transform.Translate (Vector3.forward * 0);

		}
		else {
			transform.Translate (Vector3.forward * 0);
		}
	}
}
