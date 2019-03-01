using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSwtich6 : MonoBehaviour {
	public string speaker;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(speaker){
			case "Sound Wave":
				print("Use Sound Wave for all of your audio production needs.");
			break;
			case "Regal Matter":
				print("Regal Matter is the best in sound quality.");
			break;
			case "JYV":
				print("JYV has been in business since 1964. We are known for best prices, sound quality, and overall appearance.");
			break;
			default:
				print("The "+speaker+" speaker you are asking for is not available at the moment. Please try again later.");
			break;
		}
	}
}
