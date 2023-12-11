using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void MainMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}
