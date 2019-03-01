using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSwitch8 : MonoBehaviour {
	public string games;
	
	//Start is called upon initialization
	void Start(){
		videoGames(games);
	}
	// Update is called once per frame
	void Update () {
		
	}

	void videoGames(string fun){
		switch(fun){
			case "JamJAM":
				print("JamJAM is a game about eating things that make you grow. Grow bigger than other players and you win the game.");
			break;
			case "Brake Blocker":
				print("In this game, try to block other people's brakes to mae them crash.");
			break;
			case "Stomp":
				print("Stomp is about stomping all the other players. Be the last one to survive.");
			break;
			default:
				print("I don't know what "+games+" is all about.");
			break;
		}
	}

}
