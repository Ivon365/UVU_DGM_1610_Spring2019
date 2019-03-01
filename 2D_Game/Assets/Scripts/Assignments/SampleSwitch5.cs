using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSwitch5 : MonoBehaviour {
	public string phone;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(phone){
			case "Sasmoso":
				print("The Sasmoso is the best phone on the market today!");
			break;
			case "IG":
				print("The IG phone is best for those who are into music.");
			break;
			case "Pear":
				print("The pear phone has best in class security, great for music, and also has the best apps around.");
			break;
			default:
				print("I'm not sure what "+phone+" you are talking about.");
			break;
		}
		
	}
}
