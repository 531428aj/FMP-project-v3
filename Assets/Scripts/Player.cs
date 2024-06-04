using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float playerHealth;
    public float maxHealth = 100;
    public float enimiesKilled = 0;


    private void Start()
    {
        playerHealth = maxHealth;
        
    }


    public void PlayerTakeDamage(float amount)
    {
        playerHealth -= amount;

        if (playerHealth <= 0f)
        {
            print("You're dead lmao");
            SceneManager.LoadScene("Game");

        }
    }




    public GameObject player;
}
