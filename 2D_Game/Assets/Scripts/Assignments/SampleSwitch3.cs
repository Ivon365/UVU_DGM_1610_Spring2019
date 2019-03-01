using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSwitch3 : MonoBehaviour {

	public string chairs;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(chairs){
			case "Fold-a-leg 3000":
				print("The most comfortable leg chair since the year 3050!");
			break;
			case "Zap Away":
				print("The fastest chair since the hoverchair!");
			break;
			case "Crumby DOT exe":
				print("Don't let this crappy chair of the future fool you with its executables!");
			break;
			default:
				print("I don't know what type of "+chairs+" you are talking about!");
			break;
		}
	}
}
