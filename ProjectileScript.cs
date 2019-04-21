using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public GameObject player;
    public float damage;

    public virtual void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject != player && col.collider.gameObject.CompareTag("Player"))
        {
            if (!col.gameObject.GetComponent<Player2DController>().isParrying)
            {
            
                col.collider.gameObject.GetComponent<Player2DController>().hp -= damage;
            }
            else
            {
                col.gameObject.GetComponent<Player2DController>().parryTimer = 3.0f;
            }
        }
        if (col.collider.gameObject.CompareTag("Shield"))
        {
            col.gameObject.GetComponent<Player2DController>().hp -= damage/2f;
        }
        Destroy(this.gameObject);
    }
}
