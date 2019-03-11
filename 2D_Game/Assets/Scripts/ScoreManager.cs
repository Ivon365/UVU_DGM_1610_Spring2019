using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int score;

//Access modifiers are private by default if no access modifiers are listed (e.i. public or private)
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();

        //resets score to 0
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        //one line if statements do not need an opening bracket.
        if (score < 0)
            score = 0;

        scoreText.text = " " +score;
        //nameOfObject.property
        
    }

    public static void AddPoints (int pointsToAdd){

    
        score += pointsToAdd;

        //Also the same as score = score + pointsToAdd;
    }
}
