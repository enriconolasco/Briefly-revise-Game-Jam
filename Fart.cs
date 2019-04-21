using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fart : MonoBehaviour
{
    public GameObject player;
    public float damage;

    void OnCollisionEnter2D  (Collision2D col)
    {
        if (col.collider.gameObject.CompareTag("Player") && col.gameObject != player) //not this gameObject
        {
            if (!col.gameObject.GetComponent<Player2DController>().isParrying)
            {
                col.gameObject.GetComponent<Player2DController>().hp -= damage;
            }
            else
            {
                col.gameObject.GetComponent<Player2DController>().parryTimer = 3.0f;
            }
        }
        if (col.collider.gameObject.CompareTag("Shield"))
        {
            col.gameObject.GetComponent<Player2DController>().hp -= damage/2 ;
        }
    }
}
