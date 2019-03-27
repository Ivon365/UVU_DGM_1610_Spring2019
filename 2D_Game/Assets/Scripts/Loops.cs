using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{


    // public int bottles = 0;
    // Start is called before the first frame update
    void Start()
    {
        //For loop = operate within finite parameters
        // for(int i=100; i <= bottles; i--){
        //     print(i +" bottles of milk on the wall.");
        // }
        
        // bool shouldContinue = false;

        // //do-while loops always run a minimum of once even if the statement is false.
        // do
        // {
        //     print ("Hello World");
        // }
        // while(shouldContinue == true);

        //foreach loops are great for looping through an array once per array.

        string[] strings = new string[3];

        strings[0] = "First String";
        strings[1] = "Second String";
        strings[3] = "Third String";

        foreach(string item in strings)
        {
            print(item);
        }

        // while(bottles <= 100){
        //     print(bottles + " bottles of milk on the wall");
        // }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
