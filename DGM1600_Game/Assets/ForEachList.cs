using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachList : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		
		List<FirstOrder> badGuys = new List<FirstOrder>();

		badGuys.Add( new FirstOrder("Snoke", 1000));
		badGuys.Add( new FirstOrder("General Hux", 20));
		badGuys.Add( new FirstOrder("Kylo Ren", 400));
		badGuys.Add( new FirstOrder("Captain Phasma", 150));

		badGuys.Sort();

		foreach(FirstOrder guy in badGuys){
			print(guy.villianName + " " + guy.power);
		}

	}

}
