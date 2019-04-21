using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CliffordProjectile : MonoBehaviour
{
    //this actually for the house (special)
    public GameObject player;
    public int damage;

    public virtual void OnCollisionEnter2D(Collision2D col)
    {
        bool destroy = true;
        if (col.gameObject.GetComponent<Player2DController>() && col.gameObject != player)
        {
            col.collider.gameObject.GetComponent<Player2DController>().hp -= 5;
        }
        if (destroy)
            Destroy(this.gameObject);
    }
}
