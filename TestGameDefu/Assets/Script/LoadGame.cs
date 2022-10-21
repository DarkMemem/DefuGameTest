using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void PlayGame()
    {
        Player.score = 0;
        Time.timeScale = 1f;
        int rand_level = Random.Range(1, 10);
        SceneManager.LoadScene(rand_level);
        Debug.Log(rand_level);
    }
}
