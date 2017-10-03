using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOP : MonoBehaviour {

	public string luke = "Jedi";
	public string vader = "Sith";
	public bool leia = true;
	public string darkSide = "Darth Maul";
	public string lightSide = "Obi-Wan";
	public bool virus = true;
	public bool hardDriveCrash = false;


	// Logical Operators allow coders to test for multiple statements in a single loop.  They can test for
	// situations where two statements are true, where one of two statements is true, or where no statements are true.
	// This can be done by using the &&, ||, and ! operators.


	// Use this for initialization
	void Start () {

		if(luke == "Jedi" && vader == "Nanny"){
			print("Vader's yo Nanny!");
		}
		else if(luke == "Jawa" && vader == "Sith"){
			print("Utinni!");
		}
		else if(luke == "Jedi" && vader == "Sith"){
			print("Nooooooooooooo! That's not true......");
		}
		else{
			print("The End.");
		}

		if(leia){
			print("No, there is another.");
		}
		else if(!leia){
			print("Hurray! Now I can date Luke!");
		}
		else{
			print("Han fired first!");
		}

		if(lightSide == "Obi-Wan" || darkSide == "Jar Jar Binks"){
			print("Meeeza Evil bad-bad Sith Lord.");
		}
		else if(lightSide == "Boba Fett" || darkSide == "Darth Maul"){
			print("As you wish, my master.");
		}
		else{
			print("Not the younglings!");
		}

		if(virus == true && hardDriveCrash == true){
			print("Dead Computer");
		}
		else if(virus == true || hardDriveCrash == true){
			print("Get IT.");
		}
		else
			print("Everything's fine.");

		


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
