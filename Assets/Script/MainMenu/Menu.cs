using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadGame()
    {
        //load the game scene
        SceneManager.LoadScene(1); //Game Scene
    }
}
