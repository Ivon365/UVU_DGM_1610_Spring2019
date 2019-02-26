using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Statements : MonoBehaviour
{
    public string stopLight;
    public bool isUtahn = false;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
        if(stopLight == "Red"){
        //Block of code that is run if the condition is met
            if(isUtahn){
                print("STOP! The light is RED!");
            }
            else{
                print("Thank you for stopping at the red light!");
            }
        }
        else if (stopLight == "Yellow"){
            if(isUtahn){
                print("You got this brah!");
            }
            else{
                print("Thank you for preparing to stop!");
            }
        }
        else if (stopLight == "Green" && !isUtahn){
            print("Check phone, turn up radio, sit at the light until almost yellow, then go!");
        }
        //if condition is NOT met then condition will run else code
        else{
            print("Sorry, you are driving in Utah!");
        }
    }
}
