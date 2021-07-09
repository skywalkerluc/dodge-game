using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // public GoToSettingsMenu() {
    //     SceneManager.LoadScene("SettingsMenu");
    // }

    // public GoToMainMenu() {
    //     SceneManager.LoadScene("SettingsMenu");
    // }

    public void QuitGame() {
        Application.Quit();
    }
}
