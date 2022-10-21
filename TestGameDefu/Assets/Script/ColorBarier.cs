using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBarier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player.player.transform.tag = this.tag;
    }
}
