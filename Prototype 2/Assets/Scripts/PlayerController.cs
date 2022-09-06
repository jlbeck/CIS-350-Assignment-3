﻿/*
 * Josh Beck
 * Prototype 2
 * Controls player character
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 14;

    // Update is called once per frame
    void Update()
    {

        //get horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        //transform horizontally with player input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keep player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

    }
}
