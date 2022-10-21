using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSize : MonoBehaviour
{
    public static void SizeUp()
    {
        if (Player.heal <= 10)
        {
                if (Player.player.transform.localScale.x < Player.maxScale)
                    Player.player.transform.localScale = new Vector3(Player.player.transform.localScale.x + 0.05f,
                        Player.player.transform.localScale.y + 0.05f, Player.player.transform.localScale.z + 0.05f);
        }
    }

    public static void SizeDown()
    {
        if (Player.heal >= 0)
        {
            Player.player.transform.localScale = new Vector3(Player.player.transform.localScale.x - 0.05f, 
                Player.player.transform.localScale.y - 0.05f, Player.player.transform.localScale.z - 0.05f);
        }
        else if (Player.heal < 0)
        {
            Time.timeScale = 0f;
            Player.heal = 0;
        }
    }
}
