using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foxShield : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("projectile"))
        {
            transform.localScale = new Vector3(0.7f, 0.7f, transform.localScale.z);
            Destroy(col.gameObject);
        }
    }
}
