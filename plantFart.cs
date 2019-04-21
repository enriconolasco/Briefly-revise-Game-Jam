using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantFart : MonoBehaviour
{
    public GameObject player;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.gameObject.CompareTag("Player") && col.gameObject != player) //not this gameObject
        {
            if (!col.gameObject.GetComponent<Player2DController>().isParrying)
            {
                col.gameObject.GetComponent<Player2DController>().hp -= 4.5f;
            }
            else
            {
                col.gameObject.GetComponent<Player2DController>().parryTimer = 3.0f;
            }
        }
        if (col.collider.gameObject.CompareTag("Shield"))
        {
            col.gameObject.GetComponent<Player2DController>().hp -= 2.25f;
        }
        if (col.gameObject.CompareTag("Player") && col.gameObject == player)
        {
            col.gameObject.GetComponent<Player2DController>().hp++;
        }
        Destroy(this.gameObject);
    }
}
