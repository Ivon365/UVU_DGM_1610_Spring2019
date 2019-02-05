using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript4 : MonoBehaviour {

	public string lightState;

//Use this for initialization
	void Start(){
		Light(lightState);
	}

	void Light(string lightState){

		if(lightState == "On"){
			print("You turn on the light.");
		}
		else if(lightState == "Off"){
			print("You turn off the light.");
		}
		else{
			print("I don't understand "+lightState);
		}
	}
}
