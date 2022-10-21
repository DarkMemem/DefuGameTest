using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private bool isDown;
    [SerializeField] private bool isLeft;
    
    private void FixedUpdate()
    {
        if (isDown== true)
        {
            Quaternion rotationY = Quaternion.AngleAxis(1, Vector3.down);
            transform.rotation *= rotationY;
        }
        if (isLeft == true)
        {
            Quaternion rotationY = Quaternion.AngleAxis(1, Vector3.left);
            transform.rotation *= rotationY;
        }   
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PinkPlayer"))
            if (this.CompareTag("PinkEnemy") == other.CompareTag("PinkPlayer"))
            {
                Player.CheckHealUp();
            }
            else
            {
                Player.CheckHealDown();
            }
        else if (other.CompareTag("RedPlayer"))
            if (this.CompareTag("RedEnemy") == other.CompareTag("RedPlayer"))
            {
                Player.CheckHealUp();
            }
            else
            {
                Player.CheckHealDown();
            }
        else if (other.CompareTag("WhitePlayer"))
            if (this.CompareTag("WhiteEnemy") == other.CompareTag("WhitePlayer"))
            {
                Player.CheckHealUp();
            }
            else
            {
                Player.CheckHealDown();
            }
        else if (other.CompareTag("YellowPlayer"))
            if (this.CompareTag("YellowEnemy") == other.CompareTag("YellowPlayer"))
            {
                Player.CheckHealUp();
            }
            else
            {
                Player.CheckHealDown();
            }
        Destroy(this.gameObject);
    }
}