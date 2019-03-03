using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleIfStatement10 : MonoBehaviour
{
    public string CouchPotato;
    public bool PlayingGames = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CouchPotato == "True"){
            if(PlayingGames){
                print("You better get off that game and go play outside!");
            }
            else{
                print("Don't watch too much TV. You'll burn your eyes out.");
            }
        }
        else if(CouchPotato == "False"){
            if(PlayingGames){
                print("Have you done your homework?");
            }
            else{
                print("Way to go!");
            }
        }
    }
}
