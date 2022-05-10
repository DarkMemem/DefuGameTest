using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{    
    public int score;
    public int heal;
    public Text healDisplay;
    public Text[] scoreDisplay;
    public GameObject panelLose;
    public GameObject panelWin;
    public GameObject player;
    public float maxScale = 1f;

    private void Update()
    {
        healDisplay.text = "Heal: " + heal.ToString();
        scoreDisplay[0].text = "Score: " + score.ToString();
        scoreDisplay[1].text = score.ToString();
        scoreDisplay[2].text = score.ToString();
        if (heal > 10)
            heal = 10;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GreenEnemy"))
            if (player.CompareTag("GreenPlayer") == other.CompareTag("GreenEnemy"))
            {
                heal++;
                score++;
                CheckHealUp();
            }
            else
            {
                Debug.Log("Score down Gren");
                CheckHealDown();
            }
        else if (other.CompareTag("RedEnemy"))
            if (player.CompareTag("RedPlayer") == other.CompareTag("RedEnemy"))
            {
                heal++;
                score++;
                CheckHealUp();
            }
            else
            {
                Debug.Log("Score down Red");
                CheckHealDown();
            }
        else if (other.CompareTag("PinkEnemy"))
            if (player.CompareTag("PinkPlayer") == other.CompareTag("PinkEnemy"))
            {
                heal++;
                score++;
                CheckHealUp();
            }
            else
            {
                Debug.Log("Score down Pink");
                CheckHealDown();
            }
        else if (other.CompareTag("YellowEnemy"))
            if (player.CompareTag("YellowPlayer") == other.CompareTag("YellowEnemy"))
            {
                heal++;
                score++;
                CheckHealUp();
            }
            else
            {
                Debug.Log("Score down Yellow");
                CheckHealDown();
            }
        else if (other.CompareTag("Barrier"))
        {
            if (player)
            {
                heal = 0;
                CheckHealDown();
            }
        }
        else if (other.gameObject.name == "FinishLine")
        {
            panelWin.SetActive(true);
        }
    }


    private void CheckHealUp()
    {
        if (heal <= 10)
        {
            if (this.transform.localScale.x < maxScale)
                this.transform.localScale = new Vector3(this.transform.localScale.x + 0.05f, this.transform.localScale.y + 0.05f, this.transform.localScale.z + 0.05f);
        }
    }
    private void CheckHealDown()
    {
        heal--;
        if (heal >= 0)
        {
            player.transform.localScale = new Vector3(this.transform.localScale.x - 0.05f, this.transform.localScale.y - 0.05f, this.transform.localScale.z - 0.05f);
        }
        else if (heal < 0)
        {
            Time.timeScale = 0f;
            heal = 0;
            healDisplay.gameObject.SetActive(false);
            scoreDisplay[0].gameObject.SetActive(false);
            panelLose.SetActive(true);
        }
    }
}
