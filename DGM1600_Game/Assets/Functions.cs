using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

	public void DoStuff(){
		print("I'm doing stuff...");
		int result = AddNumbers(5, 11);
		print (result);
	}

	void Start(){
		DoStuff();
	}

	public int AddNumbers(int num1, int num2){
		int result = num1 + num2;
		return result;
	}

}
