using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBarier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.tag = this.tag;
    }
}
