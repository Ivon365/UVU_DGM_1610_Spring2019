using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	public int HealthWindow = 100;
	public int currentHP;

	public Text Health;

	void Start () {
		currentHP = HealthWindow;
	}
	
	// Update is called once per frame
	void Update () {
		Health.text = currentHP.ToString();
		
	}

	public void DamageDealt(int amt){
		currentHP -= amt;
		if(currentHP <= 0){
			currentHP = 0;
			print("You died! Game over!");
		}
	}
}
