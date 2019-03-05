using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

	public string weather;


	void Start(){
		Weather(weather);
		/*See functions that return a value below
		Print returns a value to the console. */
		print(Sum(36,24));
		print(Multi(20,5));
	}

	void Weather(string weatherState){

		if(weatherState == "Sunny"){
			print("The sun is shining today!");
		}
		else if(weatherState == "Raining"){
			print("It is soggy and wet today!");
		}
		else if(weatherState == "Windy"){
			print("It is blowing harder than a desk fan today!");
		}
		else if(weatherState == "Snowing"){
			print("Baby it's cold outside!");
		}
		else if(weatherState == "Foggy"){
			print("Visiblity is very poor due to fog!");
		}
		else{
			print("I don't understand "+weatherState);
		}
	}

	/* Functions that can return a value
	return returns a value of two or more variables */

	int Sum(int a, int b){
		return a + b;
	}
	int Multi(int c, int d){
		return c * d;
	}
}
