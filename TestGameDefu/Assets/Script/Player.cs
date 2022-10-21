using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] public static int score;
    [SerializeField] public static int heal;
    [SerializeField] public GameObject panelWin;
    [SerializeField] public static GameObject player;
    [SerializeField] public static float maxScale = 1.5f;

    public void Start()
    {
        Player.player = this.gameObject;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barrier"))
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
            heal = 0;
        }
    }

    public static void CheckHealUp()
    {
        if (heal < 10)
            heal++;
        score++;
        PlayerSize.SizeUp();
    }

    public static void CheckHealDown()
    {
        heal--;
        PlayerSize.SizeDown();
    }
}
