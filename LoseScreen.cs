using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoseScreen : MonoBehaviour
{
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            transform.localScale = new Vector2(9f, 9f);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.name == "greek statue(Clone)")
        {
            SceneManager.LoadScene(5);
        }
        if (col.gameObject.name == "plant(Clone)")
        {
            SceneManager.LoadScene(6);
        }
        if (col.gameObject.name == "Clifford(Clone)")
        {
            SceneManager.LoadScene(7);
        }
        if (col.gameObject.name == "Transcence(Clone)")
        {
            SceneManager.LoadScene(8);
        }
        if(col.gameObject.name == "fox mccloud(Clone)")
        {
            SceneManager.LoadScene(9);
        }
    }
}
