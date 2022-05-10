using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    private Animator animator;
    public bool right;
    public bool left;
    public int speed = 1;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Rotaition();
    }

    private void Rotaition()
    {
        if (right == true)
        {
            transform.Rotate(0, 0, -speed);
        }

        if (left == true)
        {
            transform.Rotate(0, 0, speed);
        }
    }
}
