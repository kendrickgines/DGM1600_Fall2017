using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	public string townCenter = "main";
	public string townGaurd = "run";

	// Use this for initialization
	void Start () {
		
		print("You arrive at the Town Center");

		switch(townCenter){
			case "main":
				print("You walk down main street and find a bakery.");
			break;
			case "center":
				print("You walk down Center Street and find a sports supplier.");
			break;
			case "backAlley":
				print("You walk down a back alley and get jumped.");
			break;
			default:
				print("You get lost and wind up at the Town Center again.");
			break;
		}

		print("You run into a local gaurd.");

		switch(townGaurd){
			case "run":
				print("You run away quickly.");
			break;
			case "talk":
				print("You strike up a conversation with the gaurd and befriend him.");
			break;
			case "sneak":
				print("You try to sneak past, but are caught and imprisoned.");
			break;
			case "bribe":
				print("You bribe the gaurd and get away clean");
			break;
			default:
				print("He's staring you down. That didn't work.");
			break;

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
