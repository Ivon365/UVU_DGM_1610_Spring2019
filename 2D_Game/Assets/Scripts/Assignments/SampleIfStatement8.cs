using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleIfStatement8 : MonoBehaviour
{
    public string TV;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TV == "On"){
            print("You turn the TV on and watch the news.");
        }
        else if(TV == "Off"){
            print("The TV is turned off.");
        }
        else{
            print("The TV can either be on or off.");
        }
    }
}
