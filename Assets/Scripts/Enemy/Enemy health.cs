using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemyhealth : MonoBehaviour
{
    public float health = 10f;

    public Animator animator;

    public float timeModelIsDead = 5.0f;

    NavMeshAgent navMeshAgent;
    
    public void TakeDamage (float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            GetComponent<NavMeshAgent>().enabled = false;

            //animator.SetBool("Dead", true);

            StartCoroutine(decayTimer());

        }
    }

    IEnumerator decayTimer()
    {
        yield return new WaitForSeconds(timeModelIsDead);

        Destroy(gameObject);
    }
}