using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int bottles = 0;
    // Start is called before the first frame update
    void Start()
    {
        //For loop = operate within finite parameters
        for(int i=100; i <= bottles; i--){
            print(i +" bottles of milk on the wall.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
