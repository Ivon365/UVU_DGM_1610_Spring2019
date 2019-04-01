using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckPoint;
    // Was Player
	public Rigidbody2D pcRigid;
    //Was PC2
	public GameObject player;

	// Particles
	public GameObject deathParticle;
	public GameObject respawnParticle;

	//Respawn Delay
	public float respawnDelay;


	//Point Penalty on Death
	public int pointPenaltyOnDeath;
	
	// Store Gravity Value
	private float gravityStore;


	// Use this for initialization
	void Start () {
		pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
		player = GameObject.Find("Player");
		

		// Player = FindObjectOfType<Rigidbody2D> ();

	}
		
	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

//IEnumerator are a part of coroutines
	public IEnumerator RespawnPlayerCo(){
		//Generate Death Particle
		Instantiate (deathParticle, pcRigid.transform.position, pcRigid.transform.rotation);
		//Hide PC
		player.SetActive(false);
		player.GetComponent<Renderer> ().enabled = false;
		// Gravity Reset- Resets gravity and velocity
		gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
		pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
		pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		// Point Penalty
		ScoreManager.AddPoints(-pointPenaltyOnDeath);
		//Debug Message
		Debug.Log ("PC Respawn");
		//Respawn Delay
		yield return new WaitForSeconds (respawnDelay);
		//Gravity Restore
		pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
		//Match Players transform position
		pcRigid.transform.position = currentCheckPoint.transform.position;
		//Show Player
		// player.enabled = true;
		player.SetActive(true);
		pcRigid.GetComponent<Renderer> ().enabled = true;
		//Spawn Particle
		Instantiate (respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
	}
}