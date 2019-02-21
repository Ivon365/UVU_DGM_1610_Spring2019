using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

//player movement variables
public float moveSpeed; 
public float jumpHeight;

//player grounded variables
private bool grounded;

// this && that (this and that must be true)
// this || that (this or that must be true)
// !Not this (Think of not gates in minecraft if true won't run, if not true will run)

	// Use this for initialization
	void Start () {
		grounded = true

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		} 
		else if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y); 
	}
		
		if(Input.GetKeyDown(KeyCode.W)&& grounded){
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
		}
	
}
}
