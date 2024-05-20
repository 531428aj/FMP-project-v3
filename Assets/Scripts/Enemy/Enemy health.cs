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

        if (health > 0)
        {
            health -= amount;
            if (health <= 0f)
            {
                //134 enemies
                GetComponent<NavMeshAgent>().enabled = false;

                StartCoroutine(decayTimer());

            }
        }
    }

    IEnumerator decayTimer()
    {
        yield return new WaitForSeconds(timeModelIsDead);

        Destroy(gameObject);
    }
}