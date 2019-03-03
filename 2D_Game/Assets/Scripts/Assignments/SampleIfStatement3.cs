using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleIfStatement3 : MonoBehaviour
{
    public string pen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pen == "Open"){
            print("You are now able to write with the pen.");
        }
        else if(pen == "Closed"){
            print("You are not able to write with the pen.");
        }
        else{
            print("The function variable: "+pen+" is not a viable variable.");
        }
    }
}
