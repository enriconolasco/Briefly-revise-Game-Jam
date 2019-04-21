using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class music : MonoBehaviour
{
    public AudioSource asrc;
    public int level;
    public int level2;
    public int level3;
    public int level4;
    public int level5;
    public int level6;
    public int level7;

    void Awake()
    {
        asrc = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == level)
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().buildIndex == level2)
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().buildIndex == level3)
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().buildIndex == level4)
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().buildIndex == level5)
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().buildIndex == level6)
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().buildIndex == level7)
        {
            Destroy(this.gameObject);
        }
    }
}

