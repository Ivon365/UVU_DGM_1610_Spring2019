using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	public Transform FirePoint;
	public GameObject projectile;

	// Use this for initialization
	void Start () {
		projectile = Resources.Load("Prefabs/Projectile") as GameObject;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl))
			Instantiate(projectile, FirePoint.position, FirePoint.rotation);
		
	}
}
