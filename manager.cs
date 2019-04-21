using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class manager : MonoBehaviour
{
    public int selection1;
    public int selection2;
    public int stageSelection1;
    public int stageSelection2;

    public int load1;
    public int load2;

    public GameObject greek;
    public GameObject plant;
    public GameObject clifford;
    public GameObject brain;
    public GameObject fox;

    public GameObject loc1;
    public GameObject loc2;

    bool spawn = false;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {      
        if ((SceneManager.GetActiveScene().buildIndex == 3 || SceneManager.GetActiveScene().buildIndex == 4) && spawn == false)
        {
            loc1 = GameObject.Find("location1");
            loc2 = GameObject.Find("location2");
            switch (selection1)
            {
                case 1:
                    GameObject player = Instantiate(greek, loc1.transform.position, Quaternion.identity);
                    player.GetComponent<Player2DController>().isPlayer1 = true;
                    break;
                case 2:
                    GameObject player0 = Instantiate(plant, loc1.transform.position, Quaternion.identity);
                    player0.GetComponent<Player2DController>().isPlayer1 = true;
                    break;
                case 3:
                    GameObject player9 = Instantiate(clifford, loc1.transform.position, Quaternion.identity);
                    player9.GetComponent<Player2DController>().isPlayer1 = true;
                    break;
                case 4:
                    GameObject player8 = Instantiate(brain, loc1.transform.position, Quaternion.identity);
                    player8.GetComponent<Player2DController>().isPlayer1 = true;
                    break;
                case 5:
                    GameObject player7 = Instantiate(fox, loc1.transform.position, Quaternion.identity);
                    player7.GetComponent<Player2DController>().isPlayer1 = true;
                    break;
            }
            switch (selection2)
            {
                case 1:
                    GameObject player2 = Instantiate(greek, loc2.transform.position, Quaternion.identity);
                    player2.GetComponent<Player2DController>().isPlayer1 = false;
                    break;
                case 2:
                    GameObject player02 = Instantiate(plant, loc2.transform.position, Quaternion.identity);
                    player02.GetComponent<Player2DController>().isPlayer1 = false;
                    break;
                case 3:
                    GameObject player92 = Instantiate(clifford, loc2.transform.position, Quaternion.identity);
                    player92.GetComponent<Player2DController>().isPlayer1 = false;
                    break;
                case 4:
                    GameObject player82 = Instantiate(brain, loc2.transform.position, Quaternion.identity);
                    player82.GetComponent<Player2DController>().isPlayer1 = false;
                    break;
                case 5:
                    GameObject player72 = Instantiate(fox, loc2.transform.position, Quaternion.identity);
                    player72.GetComponent<Player2DController>().isPlayer1 = false;
                    break;
            }
            spawn = true;
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().buildIndex == 2 && (selection1 != 0 && selection2 != 0) && stageSelection1 != 0)
        {
            switch (stageSelection1)
            {
                case 1:
                    load1 = 3;
                    break;
                case 2:
                    load1 = 4;
                    break;
            }
            SceneManager.LoadScene(load1);
        }
    }
}
