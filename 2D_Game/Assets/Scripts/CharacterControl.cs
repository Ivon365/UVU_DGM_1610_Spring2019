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

//player on wall variables
public bool onWall;
public Transform wallCheck;
public float wallCheckRadius;
public LayerMask whatIsWall;

public Vector3 scale;

// this && that (this and that must be true)
// this || that (this or that must be true)
// !Not this (Think of not gates in minecraft if true won't run, if not true will run)

// Use this for initialization
void Start () {
	scale = transform.localScale;

}

void FixedUpdate(){
	//this is for jumping off the ground
	grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	//this is for jumping off the wall
	onWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);
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
		
		//Make player jump off the ground
		if(Input.GetKeyDown(KeyCode.W)&& grounded){
			Jump();
		}

		//Make player jump off the wall
		if (Input.GetKeyDown(KeyCode.W)&& onWall){
			Jump();
		}

		//Player flip
		if (GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(scale.x,scale.y,scale.z);

		else if (GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-scale.x,scale.y,scale.z);
	}
	void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
	}
}
