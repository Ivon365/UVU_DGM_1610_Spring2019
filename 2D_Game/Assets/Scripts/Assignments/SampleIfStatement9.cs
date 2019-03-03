using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleIfStatement9 : MonoBehaviour
{
    public string mouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mouse == "Left Click"){
            print("You left clicked on something.");
        }
        else if(mouse == "Right Click"){
            print("You right clicked on something.");
        }
        else if(mouse == "Middle Click"){
            print("You used the middle click and scroll.");
        }
        else{
            print("There are only three buttons on this mouse!");
        }
    }
}
