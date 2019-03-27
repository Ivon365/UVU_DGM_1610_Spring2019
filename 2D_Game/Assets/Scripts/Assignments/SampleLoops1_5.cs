using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleLoops1_5 : MonoBehaviour {

	public int dogs = 0;
	public int yams = 100;
	public int shirts = 1000;
	public int straws = 5;
	public int plates = 10;

	// Use this for initialization
	void Start () {
		for(int e=10; e <= dogs; e--){
			print(e + " puppies are left sleeping.");
		}

		// while(dogs <= 50){
		// 	print(dogs + " dogs are running around.");
		// }

		for(int y=0; y >= yams; y++){
			print(y + " yams are left in the can,");
		}

		// while(yams >= 0){
		// 	print(yams + " yams are gross.");
		// }

		for(int a=1; a >= shirts; a++){
			print(a + " shirts on my body");
		}

		// while(shirts >= 1){
		// 	print(shirts + " shirts are awesome");
		// }

		for(int t=0; t >= straws; t++){
			print(t + " straws are in my cup.");
		}

		// while(straws >= 0){
		// 	print(straws + " straws puncturing the lid");
		// }

		for(int p=0; p >= plates; p++){
			print(p + " plates purchased today");
		}

		// while(plates >= 0){
		// 	print(plates + " plates are in the cupboard");
		// }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
