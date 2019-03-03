using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleIfStatement7 : MonoBehaviour
{
    public string drawer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(drawer == "Open"){
            print("The drawer is open. You found nothing inside.");
        }
        else if(drawer == "Close"){
            print("The drawer is closed and you can't open it.");
        }
        else{
            print("The drawer shuns you for typing that.");
        }
    }
}
