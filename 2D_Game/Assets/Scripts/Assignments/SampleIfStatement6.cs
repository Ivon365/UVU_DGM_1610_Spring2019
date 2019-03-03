using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleIfStatement6 : MonoBehaviour
{
    public string power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(power == "On"){
            print("The power is on.");
        }
        else if(power == "Off"){
            print("The power is off.");
        }
        else{
            print("That is not a valid power state.");
        }
    }
}
