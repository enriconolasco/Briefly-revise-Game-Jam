using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserScript : MonoBehaviour
{
    public GameObject player;
    public float damage;

    public virtual void OnTriggerEnter2D(Collider2D col)
    {
        bool destroy = true;
        if (col.CompareTag("Player") && col.gameObject != player)
        {
            col.gameObject.GetComponent<Player2DController>().hp -= damage;
        }
        if (destroy)
            Destroy(this.gameObject);
    }
}
