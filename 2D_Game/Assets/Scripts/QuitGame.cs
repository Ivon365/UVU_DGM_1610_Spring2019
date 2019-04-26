using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
public void LevelExit(){
    Debug.Log("Player has quit game.");
        Application.Quit();
    }
}
