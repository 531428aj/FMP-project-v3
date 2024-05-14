using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public float playerHealth = 100f;


    public void PlayerTakeDamage(float amount)
    {
        playerHealth -= amount;

        if (playerHealth <= 0f)
        {
            print("You're dead lmao");

            //animator.SetBool("Dead", true);

 

        }
    }




    public GameObject player;
}
