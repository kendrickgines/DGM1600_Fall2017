using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablePractice : MonoBehaviour {

	// The purpose of this assignment is to showcase my understanding of variables.  
	// A variable is a changable value within a system.  It is basically a container for data.
	// There are several types of variables.
	// Integers

	public int Coins = 20;

	// Integers contain whole number values.  They work well for things that are not percentage based.
	// Strings are another type of variable

	public string Name = "John Doe";
	// Strings hold multiple characters.  They are useful for displaying text, and must always be within quotes.
	
	public char middleInitial = 'C';
	// Characters hold a single character.

	public bool alive = true;

	// Booleans are basically true or false statements.  

	public float cents = 0.54f;

	// Floats are decimal values.  They are useful when working with partial numbers.

	public double money = 2.52;

	// Doubles are kind of like the jack of all trades of numerical data.  They can contain both whole, and partial numbers.
	// Doubles take up more data than other numerical variables, so it is often better to use foats or ints unless you need the flexibility.

	// My understanding is that variables make up the basics of coding.  They don't do much on their own, but pretty much everything
	// else that we will be using depends on variables.  


}
