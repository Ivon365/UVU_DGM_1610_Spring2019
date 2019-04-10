using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPlayer : MonoBehaviour {

	public int Health;
	public int HealthCount;
	public int damageBar;
	Text HealthCounter;
	


	// Use this for initialization
	void Start () {
		Health = 100;
		HealthCount = Health;
		HealthCounter = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	public static void PlayerDamage(int PlayerDamageDealt){
		
	}
}
