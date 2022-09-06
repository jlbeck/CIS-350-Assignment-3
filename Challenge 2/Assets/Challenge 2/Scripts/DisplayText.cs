/*
 * Josh Beck
 * Challenge 2
 * Displays score and health values
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{

    public Text textbox;

    public int score = 0;
    private HealthSystem healthSystemScript;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        textbox.text = "Score:\t\t0\nHealth:\t\t" + healthSystemScript.health;
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score:\t\t" + score + "\nHealth:\t\t" + healthSystemScript.health;
    }
}
