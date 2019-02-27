using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_IF_Statements : MonoBehaviour
{
    public string Swimming;
    public bool Swimmer = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Swimming == "Can't swim"){
            if(Swimmer){
                print("I can swim!");
            }
            else{
                print("I'm drowning!");
            }
        }
        else if(Swimming == "Frontflip"){
            if(Swimmer){
                print("Look at what I can do!");
            }
            else{
                print("I'm really bad at fronflips underwater!");
            }
        }
        else if(Swimming == "Backflip"){
            if(Swimmer){
                print("I'm so awesome!");
            }
            else{
                print("I'm a noob!");
            }
        }
        else{
            print("I don't have a clue as to what you are tolkien about!");
        }
        
    }
}
