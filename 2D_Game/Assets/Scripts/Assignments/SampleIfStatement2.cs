using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleIfStatement2 : MonoBehaviour
{
    public string computer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(computer == "On"){
            print("The computer is turned on.");
        }
        else if(computer == "Off"){
            print("The computer is turned off.");
        }
        else{
            print("I do not understand: "+computer);
        }
    }
}
