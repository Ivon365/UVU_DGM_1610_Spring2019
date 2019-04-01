﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : Monobehaviour {


    public LevelManager levelManager;

    //Use this for initialization
    void Start () {
        levelManager = FindObjectOfType <LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.name == "Player"){
            levelManager.RespawnPlayer();
        }
    }
}
