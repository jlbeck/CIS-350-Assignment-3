/*
 * Josh Beck
 * Challenge 2
 * Detects and handles collisions between dog and balls
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private DisplayText displayText;

    private void Start()
    {
        displayText = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayText>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayText.score++;
        Destroy(gameObject);
    }
}
