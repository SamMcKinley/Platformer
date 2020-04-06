using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    //Powerup to spawn
    public GameObject powerupPrefab;

    private GameObject spawnedPowerup = null;

    void Start()
    {
        SpawnPowerup();  
    }

    public void SpawnPowerup()
    {
        if (spawnedPowerup == null)
        {
            spawnedPowerup = Instantiate(powerupPrefab, transform);
        }
        
    }
}
