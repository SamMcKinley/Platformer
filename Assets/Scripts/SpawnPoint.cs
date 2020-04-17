using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.instance.CurrentSpawnPoint == null)
        {
            GameManager.instance.CurrentSpawnPoint = this.transform;
        }
        GameManager.instance.SpawnPlayer();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
