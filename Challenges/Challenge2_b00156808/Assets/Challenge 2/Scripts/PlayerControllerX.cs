using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //adding cooldown 
    private float cool = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog while cooldown is less than or equal to 0
        if (Input.GetKeyDown(KeyCode.Space) && cool <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //cooldown value is 1 when dog spawned
            cool = 1;
        }
        //while cooldown is above 0
        cool -= Time.deltaTime;
    }
}
