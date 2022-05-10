using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Ok");
        Time.timeScale = 1f;
        SceneManager.LoadScene(Random.Range(1, 10));
    }
}
