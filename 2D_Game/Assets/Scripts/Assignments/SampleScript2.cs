using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript2 : MonoBehaviour {

	public string positionState;


	void Start(){
		Position(positionState);
	}

	void Position(string positionState){

		if(positionState == "Forward"){
			print("You walk forward and find a fork in the road.");
		}
		else if(positionState == "Left"){
			print("You go left and approach an ocean.");
		}
		else if(positionState == "Right"){
			print("You walk right and find a cave entrance.");
		}
		else if(positionState == "Go Back"){
			print("You attempt to walk back and find that there is a rock in the way.");
		}
		else if(positionState == "Yell"){
			print("You yell for help but no one hears you. You are too far away from town.");
		}
		else{
			print("I don't understand "+positionState);
		}
	}
}
