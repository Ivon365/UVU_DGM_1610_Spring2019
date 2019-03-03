using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleIfStatement5 : MonoBehaviour
{
    public string quiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(quiz == "Pass"){
            print("You have passed the test!");
        }
        else if(quiz == "Fail"){
            print("You have failed the test!");
        }
        else{
            print("That is not a valid input!");
        }
    }
}
