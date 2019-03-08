using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSwitch1 : MonoBehaviour {

	public string TacoGuy;
<<<<<<< Updated upstream

	// Use this for initialization
	void Start () {
		
	}
=======
>>>>>>> Stashed changes
	
	// Update is called once per frame
	void Update () {
		switch(TacoGuy){
			case "Theo":
				print("I just made a taco for a customer.");
			break;
			case "Johnny Number 5":
				print("I said a one, two, three, four, five. Man you gotta get that Taco jive! By the way, I was in the store ordering a taco.");
			break;
			case "That one guy":
				print("I feel like I want a taco. I'm outside the store.");
			break;
			default:
				print("I'm not familiar with "+TacoGuy+"!");
			break;
		}
	}
}
