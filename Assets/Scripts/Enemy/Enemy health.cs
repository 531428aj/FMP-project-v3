using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemyhealth : MonoBehaviour
{
    public float health = 10f;

    public Animator animator;

    public float timeModelIsDead = 5.0f;

    public GameObject splatPrefab;

    NavMeshAgent navMeshAgent;
    
    public void TakeDamage (float amount)
    {

        if (health > 0)
        {
            health -= amount;
            if (health <= 0f)
                
            {
                //50 enemies

                GetComponent<NavMeshAgent>().enabled = false;
                

                StartCoroutine(decayTimer());

            }
        }
    }

    IEnumerator decayTimer()
    {
        DoBloodSplat();

        yield return new WaitForSeconds(timeModelIsDead);
        Killcountscript.EnemiesLeft += 1;

        

        Destroy(gameObject);
    }


    void DoBloodSplat()
    {
        Vector3 pos = transform.position;
        print("do blood splat");

        Instantiate(splatPrefab, pos, Quaternion.identity);

    }
}