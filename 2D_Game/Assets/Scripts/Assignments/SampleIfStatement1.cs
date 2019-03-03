using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleIfStatement1 : MonoBehaviour
{
    public string phone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(phone == "Ringing"){
            print("The phone is ringing!");
        }
        else if(phone == "Not Ringing"){
            print("The phone is not ringing.");
        }
        else{
            print("I don't know what "+phone+" is.");
        }
    }
}
