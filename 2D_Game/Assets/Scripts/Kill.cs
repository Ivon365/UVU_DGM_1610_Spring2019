using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D other){
    //can be other.name or other.tag
        if(other.tag == "Player"){
            Destroy(other);
        }
    }
}
