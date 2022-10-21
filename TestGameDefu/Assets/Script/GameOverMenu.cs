using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void ResetLevel()
    {
        Time.timeScale = 1f;
        Player.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
    public void GoMenu()
    {
        Player.score = 0;
        SceneManager.LoadScene("MainMenu");
    }
}
