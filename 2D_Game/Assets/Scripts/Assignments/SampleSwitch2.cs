using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSwitch2 : MonoBehaviour {

	public string adverts;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(adverts){
			case "Jamba Man":
				print("Visit Jamba Man for all of your hardware needs!");
			break;
			case "Pocket Juice":
				print("Need more battery life? Look to Pocket Juice for all of your charging needs!");
			break;
			case "Region Manager Pro":
				print("Need to find where you live, work, or go to church? Download the Region Manager Pro app to help locate where you need to go!");
			break;
		}
	}
}
