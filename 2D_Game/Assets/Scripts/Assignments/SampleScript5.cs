using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript5 : MonoBehaviour {

	public string gameState;


	void Start(){
		Game(gameState);
	}

	void Game(string gameState){

		if(gameState == "Link"){
			print("HIYA!");
		}
		else if(gameState == "Navi"){
			print("Hey! Listen!");
		}
		else if(gameState == "Mario"){
			print("It's a me! Mario!");
		}
		else if(gameState == "Luigi"){
			print("I'm a back!");
		}
		else if(gameState == "Hayner"){
			print("Our ______ are gone! Our ______ are gone! Stolen!");
		}
		else{
			print("I don't understand "+gameState);
		}
	}
}
