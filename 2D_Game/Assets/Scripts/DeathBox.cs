﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D other){

		

		if(other.tag == "Player"){
			Debug.Log("The player is entering the death zone");
			Destroy(other);
		}

		

	}

}
