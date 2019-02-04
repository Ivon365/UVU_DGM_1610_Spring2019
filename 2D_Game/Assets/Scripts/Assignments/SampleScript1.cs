using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript1 : MonoBehaviour {

	public string chatState;


	void Start(){
		Chat(chatState);
	}

	void Chat(string chatState){

		if(chatState == "Hello"){
			print("Hello there young villager!");
		}
		else if(chatState == "Buy"){
			print("What would you like to buy today?");
		}
		else if(chatState == "Sell"){
			print("What would you like to sell today?");
		}
		else if(chatState == "Trade"){
			print("What would you like to trade?");
		}
		else if(chatState == "Bye"){
			print("Good bye for now! Visit us anytime!");
		}
		else{
			print("I don't understand "+chatState);
		}
	}
}
