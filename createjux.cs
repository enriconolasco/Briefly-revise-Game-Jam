using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createjux : MonoBehaviour
{
    public GameObject jb;

    void Update()
    {
        if (!GameObject.Find("jukeBox2"))
        {
            Instantiate(jb);
        }
    }


}
