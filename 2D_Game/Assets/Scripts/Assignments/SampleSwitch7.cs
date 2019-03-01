using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSwitch7 : MonoBehaviour {
	public string president;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(president){
			case "Theodore Roosevelt":
				print("Thodore was the 20th president of te United States");
			break;
			case "Donald Trump":
				print("Donald is the current president of the United States.");
			break;
			case "Barack Obama":
				print("Barack Obama was the previous president of the United States.");
			break;
			default:
				print("Please research "+president+" to get more information about this president.");
			break;
		}
		
	}
}
