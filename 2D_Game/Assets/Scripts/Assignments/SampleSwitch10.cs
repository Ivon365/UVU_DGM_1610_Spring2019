using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSwitch10 : MonoBehaviour {
	public string music;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(music){
			case "EDM":
				print("Listen to your favorite Electronic Dance Music.");
			break;
			case "Country":
				print("Listen to your favorite Country songs.");
			break;
			case "Rock":
				print("Listen to your favorite rock artists.");
			break;
			default:
				print("We do not have "+music+" genre available.");
			break;
		}
		
	}
}
