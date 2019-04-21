using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class characterSelect : MonoBehaviour
{
    public GameObject cursor1;
    public GameObject cursor2;

    public bool ready1 = false;
    public bool ready2 = false;

    public bool canMove1 = true;
    public bool canMove2 = true;

    void Update()
    {
        manage();
        if(ready1 && ready2 && SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        screenBoundaries();
        moveCursor1();
        moveCursor2();
    }

    void screenBoundaries()
    {
        if(cursor1.transform.position.y >= 5.0f)
        {
            cursor1.transform.position = new Vector3(cursor1.transform.position.x, 5.0f, cursor1.transform.position.z);
        }
        if (cursor1.transform.position.x >= 7.0f)
        {
            cursor1.transform.position = new Vector3(7.0f, cursor1.transform.position.y, cursor1.transform.position.z);
        }
        if(cursor1.transform.position.y <= -4.6f)
        {
            cursor1.transform.position = new Vector3(cursor1.transform.position.x, -4.6f, cursor1.transform.position.z);
        }
        if (cursor1.transform.position.x <= -7.0f)
        {
            cursor1.transform.position = new Vector3(-7.0f, cursor1.transform.position.y, cursor1.transform.position.z);
        }



        if (cursor2.transform.position.y >= 5.0f)
        {
            cursor2.transform.position = new Vector3(cursor2.transform.position.x, 5.0f, cursor2.transform.position.z);
        }
        if (cursor2.transform.position.x >= 7.0f)
        {
            cursor2.transform.position = new Vector3(7.0f, cursor2.transform.position.y, cursor2.transform.position.z);
        }
        if (cursor2.transform.position.y <= -4.6f)
        {
            cursor2.transform.position = new Vector3(cursor2.transform.position.x, -4.6f, cursor2.transform.position.z);
        }
        if (cursor2.transform.position.x <= -7.0f)
        {
            cursor2.transform.position = new Vector3(-7.0f, cursor2.transform.position.y, cursor2.transform.position.z);
        }
    }

    void manage()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ready2 = false;
            canMove2 = true;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            ready1 = false;
            canMove1 = true;
        }
    }

    void moveCursor1()
    {
        if (canMove1)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                cursor1.transform.Translate(Vector3.up / 10f);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                cursor1.transform.Translate(Vector3.down / 10f);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                cursor1.transform.Translate(Vector3.right / 10f);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                cursor1.transform.Translate(Vector3.left / 10f);
            }
        }
    }

    void moveCursor2()
    {
        if (canMove2)
        {
            if (Input.GetKey(KeyCode.F))
            {
                cursor2.transform.Translate(Vector3.up / 10f);
            }
            if (Input.GetKey(KeyCode.V))
            {
                cursor2.transform.Translate(Vector3.down / 10f);
            }
            if (Input.GetKey(KeyCode.B))
            {
                cursor2.transform.Translate(Vector3.right / 10f);
            }
            if (Input.GetKey(KeyCode.C))
            {
                cursor2.transform.Translate(Vector3.left / 10f);
            }
        }
    }
}
