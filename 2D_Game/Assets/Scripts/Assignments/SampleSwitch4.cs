using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSwitch4 : MonoBehaviour {
	public string coupon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(coupon){
			case "BOGO":
				print("Use this coupon to buy an item and get one free.");
			break;
			case "BOGO 50% off":
				print("Use this coupon to buy one and get on for half the price.");
			break;
			case "vary% off":
				print("Use this coupon to get the percentage off listed on the coupon.");
			break;
			default:
				print("You have inputted "+coupon+". Which I don't recognize. Please try again later.");
			break;
		}
		
	}
}
