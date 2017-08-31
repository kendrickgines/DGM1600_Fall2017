using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour {

	public class One {

		public int money = 1000000;
		public float fuel = .01f;

		private string name = "Joey";

	}	

	public class Two {

		public bool alive = true;

		public int health = 100;

		public int strength = 10;
	}

	public class Three {

		public string introMessage = "Hello";

		private string location = "Floor 3";

		private int characterCount = 3;
	}
}
