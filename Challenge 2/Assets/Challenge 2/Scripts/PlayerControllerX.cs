/*
 * Josh Beck
 * Challenge 2
 * Controls player ability to spawn in dogs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float timeSinceSpawn;

    //minimum delay since last spawn before new spawn can occur, prevents spamming
    public float minimumDelay;

    private void Start()
    {
        timeSinceSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeSinceSpawn > minimumDelay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeSinceSpawn = 0;
        }

        timeSinceSpawn += Time.deltaTime;
    }
}
