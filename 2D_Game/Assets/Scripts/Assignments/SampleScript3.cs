using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript3 : MonoBehaviour {

	public string walletState;


	void Start(){
		Wallet(walletState);
	}

	void Wallet(string walletState){

		if(walletState == "Open"){
			print("You opened your wallet.");
		}
		else if(walletState == "Close"){
			print("You closed your wallet.");
		}
		else{
			print("I don't understand "+walletState);
		}
	}
}
