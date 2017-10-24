using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

public float moveSpeed;
public float turnSpeed;
public float jumpHeight;
public float sprintSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var j = Input.GetAxis("Jump");
		var y = Input.GetAxis("Horizontal")* Time.deltaTime * turnSpeed;
		var z = Input.GetAxis("Vertical");

		if (Input.GetButton("Sprint")){
			z = Input.GetAxis("Vertical")* Time.deltaTime * (moveSpeed + sprintSpeed);
			j = Input.GetAxis("Jump")* Time.deltaTime * (jumpHeight + sprintSpeed);
		}

		else{
			z = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
			j = Input.GetAxis("Jump")* Time.deltaTime * jumpHeight;
		}

		transform.Rotate(0,y,0);
		transform.Translate(0,0,z);
		transform.Translate(0,j,0);
	}
}
