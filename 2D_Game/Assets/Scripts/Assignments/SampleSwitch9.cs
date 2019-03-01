using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSwitch9 : MonoBehaviour {
	public string paper;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(paper){
			case "Mohogany Timberwood":
				print("This kind of paper is the best for origami.");
			break;
			case "Oak Rosendale":
				print("This paper is best used for writing.");
			break;
			case "Starched Timberwood":
				print("This type of paper is best used for printing.");
			break;
			default:
				print("I don't know what "+paper+" paper that is.");
			break;
		}
		
	}
}
