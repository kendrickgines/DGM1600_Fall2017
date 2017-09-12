using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfConditionals : MonoBehaviour {

	public string stoplight = "Yellow";

void Main(){

	if(stoplight == "Red"){
		print("STOP! The light is red!");
	
	}

		else if (stoplight == "Yellow"){
			print("Clear the intersection...");
		}

		else if (stoplight == "Green"){
			print("Go!");
		}

		else{
			print("Don't know what's going on...");
		}

	
}

}

