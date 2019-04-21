using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreekSpecialScript : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.gameObject.CompareTag("Player"))
        {
            if (!col.gameObject.GetComponent<Player2DController>().isParrying)
            {

                col.gameObject.GetComponent<Player2DController>().hp -= 4;
                Destroy(this.gameObject);
            }
            else {
                col.gameObject.GetComponent<Player2DController>().parryTimer = 3.0f;
            }
        }
            if (col.collider.gameObject.CompareTag("Shield"))
            {
                col.gameObject.GetComponent<Player2DController>().hp -= 2f;
            }
            else if (col.gameObject.CompareTag("Wall"))
            {
                Destroy(this.gameObject);
            }
    }
}
