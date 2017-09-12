using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfConditionals : MonoBehaviour {


// This assignment works with if/else statements.  
// I have declared my variables here.

	public string stoplight = "Yellow";
	public bool lightSwitch = true;
	public int money = 18354;
	public int size = 10;
	public float percent = 0.15f;
	public int time = 10;
	public double earthquake = 7.4;
	public char grade = 'B';
	public bool lieDetector = false;
	public string studentName = "John";

// We used the Main class.

void Main(){

// Declaring the state of a stoplight

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

// Declaring the state of a light switch.

	if(lightSwitch == true){
		print("The light is on.");
	}
	else{
		print("The light is off.");
	}

// Declaring your financial situation.

	if(money > 100000){
		print("You are rich.");
	}
	else{
		print("You are poor.");
	}

// Declaring the size of a problem.
	
	if(size > 100){
	print("Big enough to care.");
	}
	else{
		print(" ");
	}

// Declaring a cup of water's percentage of full vs empty.

	if(percent > 0.5f){
		print("Over half.");
	}
	else{
		print("Under half.");
	}

// Keeping track of time.

	if(time > 8){
		print("Go to bed.");
	}
	else{
		print("Wake up.");
	}

// Earthquake measurement

	if(earthquake > 6){
		print("Large Earthquake");
	}
	else{
		print("Relatively small Earthquake");
	}

// Checking grades

	if(grade == 'A'){
		print("You got an A!");
	}
	else if(grade == 'B'){
		print("You got a B.");
	}
	else if(grade == 'C'){
		print("Well, you got a C.  That doesn't count for much.");
	}
	else{
		print("You failed");
	}

// Lie detector
	if(lieDetector == true){
		print("It's the truth!");
	}
	else{
		print("Its a lie!");
	}

// Remembering your friends name

	if(studentName == "Jerry"){
		print("His name is Jerry.");
	}
	else{
		print("Not sure what his name is...");
	}

}

}

