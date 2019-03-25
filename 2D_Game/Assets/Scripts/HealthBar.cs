using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	public int HealthWindow;
	public int currentHP;

	Text Health;

	void Start () {
		//Sets HP to a value of 100 at the start of the game
		HealthWindow = 100;
		//Makes the Current HP 100 at the start
		currentHP = HealthWindow;
		//Calls on the text UI in Unity
		Health = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		//Concats the " " plus the value of the current HP.
		Health.text = " " + currentHP;
		
	}

	public void DamageDealt(int damage){
		/* deducts HP depending on the amt of damage taken
		Same as currentHP=currentHP-damage */
		currentHP -= damage;
		//When HP goes to 0 then it will be game over.
		if(currentHP <= 0){
			currentHP = 0;
			print("You died! Game over!");
		}
	}
}
