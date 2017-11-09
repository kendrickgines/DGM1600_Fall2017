using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generic : MonoBehaviour {

	//position 
	// public float posX;
	// public float posY = .5f;
	// public float posZ;
	public Vector3 pos;
	//rotation
	// public float rotX;
	// public float rotY;
	// public float rotZ;
	// public float rotW = 1;
	public Quaternion rot;

	//scale
	// public float scaleX = 1;
	// public float scaleY = 1;
	// public float scaleZ = 1;
	public Vector3 scale;

	// Use this for initialization
	void Start () {
		
		scale = Vector3.one;


	}
	
	// Update is called once per frame
	void Update () {
		// transform.position = new Vector3(posX, posY, posZ);
		// transform.rotation = new Quaternion(rotX, rotY, rotZ, rotW);
		// transform.localScale = new Vector3(scaleX, scaleY, scaleZ);

		transform.position = pos;
		transform.rotation = rot;
		transform.localScale = scale;
	}
}
