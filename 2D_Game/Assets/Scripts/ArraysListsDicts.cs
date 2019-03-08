using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysListsDicts : MonoBehaviour {

	//Collection of client variables
	public string client1 = "Greg";
	public string client2 = "Kate";
	public string client3 = "Adam";
	public string client4 = "Mia";
	public string client5 = "Fred";

	//Array example- Not Scalable
	public string[] clientList = new string[]{"Greg","Kate","Adam","Mia","Fred"};

	//List example- Scalable
	public List<string> santasList = new List<string>();

	//ArrayList Example- Not viewable in editor
	public ArrayList inventory = new ArrayList();

	// Use this for initialization
	void Start () {
		santasList.Add("Jimmy");
		santasList.Add("Jenny");
		santasList.Add("Sam");
		santasList.Add("Ty");
		santasList.Add("Susie");
		santasList.Remove("Jimmy");

		print(clientList[2]);

		print(santasList[3]);

		inventory.Add(10);
		inventory.Add("Bob");
		inventory.Add(true);
		inventory.Add(5.2341);

		print(inventory[2]);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
