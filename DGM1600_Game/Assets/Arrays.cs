using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public string[] heroes = new string [6];

	// Use this for initialization
	void Start () {
		
		heroes[0] = "Batman";
		heroes[1] = "Superman";
		heroes[2] = "Wonder Woman";
		heroes[3] = "Spiderman";
		heroes[4] = "Ironman";
		heroes[5] = "Hulk";

		print(heroes[3]);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
