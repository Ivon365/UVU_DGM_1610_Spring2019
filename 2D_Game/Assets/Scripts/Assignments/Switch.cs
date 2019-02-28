using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public string suspect;

    // Start is called before the first frame update
    void Start()
    {
        MurderMystery(suspect);
    }

    void MurderMystery (string person)
    {
        
    switch(person){
        case "Mr. Ketchup":
        case "Mr. Radish":
            print("I was in the billiard room smoking a cigar and playing pool.");
        break;
        case "Mrs. Frysauce":
            print("I was talking on the rotary phone with my mother Mrs. Mayo.");
        break;
        case "Mrs. Mayo":
            print("I was in the kitchen cleaning up the dishes with the scrubber.");
        break;
        default:
            print("I am not familiar with "+suspect+"!");
        break;
        }
    }
}