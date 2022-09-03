using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    public GameObject dogPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;// = 4.0f;
    private int randomBall;

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(3, 6);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        //InvokeRepeating("SpawnDog", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 3);
        
        randomBall = Random.Range(0, 3);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);//,);
    }

    void SpawnDog()
    {
        Vector3 spawnPos = new Vector3(0, 0, 0);
        Instantiate(dogPrefabs, spawnPos, dogPrefabs.transform.rotation);
    }

}
