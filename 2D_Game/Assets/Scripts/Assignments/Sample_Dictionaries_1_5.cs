using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Dictionaries_1_5 : MonoBehaviour {

public Hashtable RubiksCube = new Hashtable();
public Hashtable Wallet = new Hashtable();
public Hashtable BusinessCard = new Hashtable();
public Hashtable Phone = new Hashtable();
public Hashtable Speaker = new Hashtable();

	// Use this for initialization
	void Start () {
		RubiksCube.Add("Top", "White");
		RubiksCube.Add("Left", "Orange");
		RubiksCube.Add("Right", "Red");
		RubiksCube.Add("Front", "Green");
		RubiksCube.Add("Back", "Blue");
		RubiksCube.Add("Bottom", "Yellow");

		print((string)RubiksCube["Top"]);

		Wallet.Add("Front", "Company Logo");
		Wallet.Add("Pocket", "Stuff");
		Wallet.Add("Back", "Nothing");

		print((string)Wallet["Front"]);

		BusinessCard.Add("Front Face", "Thank you for choosing Company!");
		BusinessCard.Add("Rear Face", "Come again soon!");

		print((string)BusinessCard["Front Face"]);

		Phone.Add("Front", "You see a blank screen");
		Phone.Add("Back", "You see the logo of the phone");

		print((string)Phone["Front"]);

		Speaker.Add("Off", "The speaker is off and you hear nothing.");
		Speaker.Add("On", "The speaker comes to life and you hear familiar faint music.");

		print((string)Speaker["Off"]);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
