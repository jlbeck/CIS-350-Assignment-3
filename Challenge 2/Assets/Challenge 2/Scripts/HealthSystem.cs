/*
 * Josh Beck
 * Challenge 2
 * Maintains health system and game over status
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public bool gameOver = false;

    public GameObject gameOverText;
    public GameObject winText;

    private DisplayText displayText;

    private void Start()
    {
        displayText = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayText>();
    }

    void Update()
    {
        //If health is somehow more than max health, set health to max health
        if (health > maxHealth)
        {
            health = maxHealth;
        }

        if (displayText.score >= 5)
        {
            gameOver = true;
            winText.SetActive(true);
        }

        if (health <= 0)
        {
            gameOver = true;
            gameOverText.SetActive(true);

        }

        if (gameOver)
        {
            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }

    }

    public void TakeDamage()
    {
        health--;
    }

    public void AddMaxHealth()
    {
        maxHealth++;
    }


}
