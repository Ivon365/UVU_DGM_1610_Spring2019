using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleIfStatement4 : MonoBehaviour
{
    public string speaker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(speaker == "On"){
            print("The sounds comes out.");
        }
        else if(speaker == "Off"){
            print("You hear nothing.");
        }
        else{
            print("I don't know that.");
        }
    }
}
