using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material[] material;
    Renderer render;
    void Start()
    {
        render = GetComponent<Renderer>();
        render.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.transform.tag = other.tag;

        if (other.gameObject.tag == "WhitePlayer")
            render.sharedMaterial = material[0];
        else if (other.gameObject.tag == "PinkPlayer")
            render.sharedMaterial = material[1];
        else if (other.gameObject.tag == "RedPlayer")
            render.sharedMaterial = material[2];
        else if (other.gameObject.tag == "YellowPlayer")
            render.sharedMaterial = material[3];

        Destroy(other.gameObject);
    }
}
