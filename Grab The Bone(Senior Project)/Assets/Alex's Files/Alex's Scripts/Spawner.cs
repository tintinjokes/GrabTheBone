using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject BImages;

    private float timeBefSpawn;
    public float startTimeAftSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    
    // Update is called once per frame
    void Update()
    {
        if(timeBefSpawn <= 0)
        {
            Instantiate(BImages, transform.position, Quaternion.identity);
            timeBefSpawn = startTimeAftSpawn;
            if(startTimeAftSpawn > minTime)
            {
                startTimeAftSpawn -= decreaseTime;
            }
            
        }
        else
        {
            timeBefSpawn -= Time.deltaTime;
        }
    }
}
