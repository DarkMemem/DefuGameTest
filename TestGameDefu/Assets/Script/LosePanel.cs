using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LosePanel : MonoBehaviour
{
    [SerializeField] public Text healDisplay;
    [SerializeField] public Text[] scoreDisplay;
    [SerializeField] public GameObject panelLose;

    public void Update()
    {
        healDisplay.text = "Heal: " + Player.heal.ToString();
        scoreDisplay[0].text = "Score: " + Player.score.ToString();
        scoreDisplay[1].text = Player.score.ToString();
        scoreDisplay[2].text = Player.score.ToString();

        if (Player.heal == 0 && Time.timeScale == 0f)
        { 
            healDisplay.gameObject.SetActive(false);
            scoreDisplay[0].gameObject.SetActive(false);
            panelLose.SetActive(true);
        }
    }
}
