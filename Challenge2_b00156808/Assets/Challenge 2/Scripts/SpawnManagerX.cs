using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        //setting array index number to be random range between 0-2
        int ballNum = Random.Range(0, ballPrefabs.Length);
        //changed the prefab array index to ballNum to insert random color
        Instantiate(ballPrefabs[ballNum], spawnPos, ballPrefabs[ballNum].transform.rotation);
        //time will range between 2 and 4 seconds 
        Invoke("SpawnRandomBall", Random.Range(2f, 4f));
    }

}
