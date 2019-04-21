using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantSpecial : MonoBehaviour
{
    public GameObject plant;
    GameObject instance;
    bool canSpawn = true;

    public GameObject player;
    bool wasPlayer1;

    void Start()
    {
        wasPlayer1 = player.GetComponent<Plant>().isPlayer1;
    }

    public void SpawnPlant()
    {
        if (canSpawn)
        {
            canSpawn = false;
            instance = Instantiate(plant, gameObject.transform.position, Quaternion.identity);
            instance.GetComponent<Player2DController>().hp = 1.0f;
            instance.GetComponent<Player2DController>().isPlayer1 = wasPlayer1;
            instance.GetComponent<Plant>().AssignText();
            instance.GetComponent<Plant>().canShootSpecial = false;
            Destroy(this.gameObject);
        }
    }
}
