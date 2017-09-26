using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour {

// There is a stark difference between propper coding conventions and propper syntax.
// While being able to make your code work is important, one of the elements that makes a good
// coder is the ability to make your code easy for others to understand.  To that end, coding
// conventions were created.  These conventions allow for greater understanding between developers by
// creating a structured system that all developers follow in creating their code.  

string charName;
int age;

	void Start () {
		
		// It is possible to write code that is will work without using the right conventions.  For example:

charName="Jerry";age=26;print(charName);print(age);

		// This will tecnically still work in a program, but the next person who reads the code will be 
		// frustrated by the way it was formatted.  A better way to do this is:

		charName = "Jerry";
		age = 26;
		print(charName);
		print(age);

		// This block of code still works, and is much easier to process by a reader.  

		// There are some conventions that are still under debate, like whether one should start a new line before including 
		// a curly brace when building a class, such as Start up above.  Some people prefer to hit enter and line up the braces.  Others will
		// keep the starting brace on the same line as the class declaration.  As a coder, I need to be aware of those who
		// will prefer it one way or another, and plan what I write accordingly. 
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
