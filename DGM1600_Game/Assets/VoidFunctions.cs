using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFunctions : MonoBehaviour {
	public int laserBlast;
	// Use this for initialization
	void Start () {
		
		DeathStar(laserBlast);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DeathStar (int vent) {
		// Destroys planets.
		print("That's no moon.  It's a space station.");

		if(vent == 1){
			print("Porkins misses the mark.");
		}
		else if(vent == 2){
			print("Old dude blows up.");
		}
		else{
			print("Luke makes the shot.");
		}
	}
}
