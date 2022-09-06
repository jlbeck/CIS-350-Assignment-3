/*
 * Josh Beck
 * Prototype 2
 * Detects collisions between food projectile and animals and handles them
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attached to food projectile prefab
public class DetectCollision : MonoBehaviour
{

    private DisplayScore displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
