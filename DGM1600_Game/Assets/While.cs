using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour {

	public int bottles = 100;
	public int weeks = 52;
	public int countDown = 30;
	public int cup = 0;

	public int boat = 100;

	public int gas = 100;

	// Use this for initialization
	void Start () {

		// While loops can be used to repeat the same action multiple times.  Incrementing the action gives it an endpoint.  
		// Here are some examples.  

		while(bottles > 0){
			print(bottles + " bottles of coke on the wall.");
			bottles--;
		}
		print("No more bottles of coke on the wall.");

		while(weeks > 0){
			print(weeks + " weeks left in the year.");
			weeks--;
		}
		print("It's a new year!");

		while(countDown > 0){
			print(countDown);
			countDown--;
		}
		print("Time's up!");

		while(cup < 100){
			print("The cup is " + cup + " percent full.");
			cup++;
		}
		print("The cup is full.");

		while(boat > 0){
			print("The boat is " + boat + " percent visible.");
			boat--;
		}
		print("The boat has sunk.");

		while(gas > 0){
			print("The gas tank is " + gas + " percent full.");
			gas--;
		}
		print("The car is stuck.");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
