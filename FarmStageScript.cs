using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmStageScript : MonoBehaviour
{
    public float timer = 0;
    bool turnedOnce = false;
    bool turnedTwo = false;
    bool turnedThree = false;

    public GameObject platform1;
    public GameObject platform2;
    public GameObject ground;
    public GameObject roof;
    public GameObject wallL;
    public GameObject wallR;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 15)
        {
            Rotate();
        }
        if(timer >= 30)
        {
            turnedOnce = true;
        }
        if(timer >= 45)
        {
            turnedTwo = true;
        }
        if(timer >= 60)
        {
            turnedThree = true;
        }
    }
    void Rotate()
    {
        bool end = false;
        if (!end)
        {
            if (transform.localEulerAngles.z < 90 && turnedOnce == false)
            {
                transform.Rotate(Vector3.forward, Time.deltaTime * 20f);
                wallL.tag = "Ground";
                wallR.tag = "Ground";
                ground.tag = "Wall";
                roof.tag = "Wall";
                platform1.tag = "Wall";
                platform2.tag = "Wall";
            }
            if (transform.localEulerAngles.z < 180 && turnedOnce == true)
            {
                transform.Rotate(Vector3.forward, Time.deltaTime * 20f);
                wallL.tag = "Wall";
                wallR.tag = "Wall";
                ground.tag = "Ground";
                roof.tag = "Ground";
                platform1.tag = "Ground";
                platform2.tag = "Ground";
            }
            if (transform.localEulerAngles.z < 270 && turnedTwo == true)
            {
                transform.Rotate(Vector3.forward, Time.deltaTime * 20f);
                wallL.tag = "Ground";
                wallR.tag = "Ground";
                ground.tag = "Wall";
                roof.tag = "Wall";
                platform1.tag = "Wall";
                platform2.tag = "Wall";
            }
            if (transform.localEulerAngles.z < 360 && turnedThree == true)
            {
                transform.Rotate(Vector3.forward, Time.deltaTime * 20f);
                wallL.tag = "Wall";
                wallR.tag = "Wall";
                ground.tag = "Ground";
                roof.tag = "Ground";
                platform1.tag = "Ground";
                platform2.tag = "Ground";
            }
            end = true;
        }
    }
}
