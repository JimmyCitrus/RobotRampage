using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    // Load the game scene
    public void StartGame()
    {
        SceneManager.LoadScene("Battle");
    }
    // Quit the application
    public void Quit()
    {
        Application.Quit();
    }
}
