using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	public string townCenter;
	public string townGaurd = "talk";
	public string shadyGuy = "fight";
	public string bakery = "cake";
	public string beggar = "cake";
	public string armory = "sword";
	public string huntingSupplier = "bow";
	public string zombieAttack = "barricade";
	public string dragon = "bow";
	public string finish = "help";

	// Use this for initialization
	void Start () {
		
		

		// print("You run into a local gaurd.");

		// switch(townGaurd){
		// 	case "run":
		// 		print("You run away quickly.");
		// 	break;
		// 	case "talk":
		// 		print("You strike up a conversation with the gaurd and befriend him.");
		// 	break;
		// 	case "sneak":
		// 		print("You try to sneak past, but are caught and imprisoned.");
		// 	break;
		// 	case "bribe":
		// 		print("You bribe the gaurd and get away clean");
		// 	break;
		// 	default:
		// 		print("He's staring you down. That didn't work.");
		// 	break;

		// }

		// print("A shady guy in a hood jumps in front of you with a knife drawn.");
		
		// switch(shadyGuy){
		// 	case "run":
		// 		print("You make a run for it, narrowly escaping the blade.");
		// 	break;
		// 	case "fight":
		// 		print("You fight him off with your kung fu skills.");
		// 	break;
		// 	case "talk":
		// 		print("You try to talk some sense into him, and get mugged.");
		// 	break;
		// 	case "wait":
		// 		print("You don't do anything, and get mugged");
		// 	break;
		// 	default:
		// 		print("That didn't work.  He demands that you hand over your valuables.");
		// 	break;
		// }

		// print("You enter a bakery.");

		// switch(bakery){
		// 	case "leave":
		// 		print("You walk right back out.");
		// 	break;
		// 	case "cake":
		// 		print("You buy a cake.");
		// 	break;
		// 	case "bread":
		// 		print("You buy some bread.");
		// 	break;
		// 	default:
		// 		print("The lady behind the counter looks at you weird and asks if you are alright.");
		// 	break;
		// }

		// print("A beggar asks you for a spare coin.");

		// switch(beggar){
		// 	case "leave":
		// 		print("You leave the poor man to fend for himself.");
		// 	break;
		// 	case "fight":
		// 		print("You beat him and take his... well... he didn't really have anything.");
		// 	break;
		// 	case "cake":
		// 		print("You give him your cake.");
		// 	break;
		// 	case "coin":
		// 		print("You give him a coin.");
		// 	break;
		// 	case "bread":
		// 		print("you give him your bread.");
		// 	break;
		// 	default:
		// 		print("He seems to think you are mocking him.");
		// 	break;
		// }

		// print("You enter the armory.");

		// switch(armory){
		// 	case "sword":
		// 		print("You see a nice sword and buy it.");
		// 	break;
		// 	case "lance":
		// 		print("You finally connect with your inner cavalier and buy a lance.");
		// 	break;
		// 	case "hammer":
		// 		print("You decide a blacksmith's life is the life for you, and buy a hammer.");
		// 	break;
		// 	case "pickaxe":
		// 		print("You buy a pickaxe.");
		// 	break;
		// 	case "leave":
		// 		print("You decide to leave the weapons to the fighters and leave without buying anything.");
		// 	break;
		// 	default:
		// 		print("Whatever you did mostly confused the merchant.");
		// 	break;
		// }

		// print("You enter a hunting supplies shop.");
		
		// switch(huntingSupplier){
		// 	case "bow":
		// 		print("You buy a bow");
		// 	break;
		// 	case "crossbow":
		// 		print("Doubting your skills, you buy a crossbow.");
		// 	break;
		// 	case "leave":
		// 		print("You decide not to buy.");
		// 	break;
		// 	default:
		// 		print("Wandering like that won't get you anywhere.");
		// 	break;
		// }

		// print("A dragon attacks the town.");

		// switch(dragon){
		// 	case "sword":
		// 		print("You use your sword to fight it and get roasted in open combat.");
		// 	break;
		// 	case "lance":
		// 		print("You use your lance to fight it, but lacking a horse you wind up toasted.");
		// 	break;
		// 	case "hammer":
		// 		print("You attack with your hammer. You don't make it.");
		// 	break;
		// 	case "pickaxe":
		// 		print("You get through it's hide using your pickaxe, but it's not enough to secure victory.");
		// 	break;
		// 	case "bow":
		// 		print("Using your bow, you manage to bring the mighty beast down.");
		// 	break;
		// 	case "crossbow":
		// 		print("Using your crossbow, you manage to secure a victory and save the town.");
		// 	break;
		// 	default:
		// 		print("That didn't work.  A building burnt down.");
		// 	break;
		// }



	}
	
	// Update is called once per frame
	void Update () {
		print("You arrive at the Town Center. Press the corresponding key to respond. Do you want to go down a) Main Street /n b) Center Street /n c) A Back Alley /n");

		if (Input.GetKeyDown("a")){
			townCenter = "main";
		}

		else if (Input.GetKeyDown("b")){
			townCenter = "center";
		}
		else if (Input.GetKeyDown("c")){
			townCenter = "backAlley";
		}

		switch(townCenter){
			case "main":
				print("You walk down main street and find a bakery.");
			break;
			case "center":
				print("You walk down Center Street and find an armory.");
			break;
			case "backAlley":
				print("You walk down a back alley and get jumped.");
			break;
			default:
				print("You get lost and wind up at the Town Center again.");
			break;
		}
	}
}
