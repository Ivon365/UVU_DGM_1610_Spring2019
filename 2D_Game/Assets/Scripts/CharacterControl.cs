using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

//player movement variables
public float moveSpeed; 
public float jumpHeight;

//player grounded variables
public bool grounded;
public Transform groundCheck;
public float groundCheckRadius;
public LayerMask whatIsGround;

// this && that (this and that must be true)
// this || that (this or that must be true)
// !Not this (Think of not gates in minecraft if true won't run, if not true will run)

// Use this for initialization
void Start () {

}

void FixedUpdate(){
	grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
}
	
	// Update is called once per frame
	void Update () {
		//Moves player left and right
		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		} 
		else if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y); 
		}
		
		//Make player jump
		if(Input.GetKeyDown(KeyCode.W)&& grounded){
			Jump();
		}
	}
	void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
	}
}
