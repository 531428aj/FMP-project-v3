using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{

    public NavMeshAgent agent;

    public Transform playerCharacter;

    public LayerMask Ground, Player;

    public Player playerHealth;

    public float attackTime;
    bool hasAttacked;

    public float attackRange = 10f;
    public float playerDamage = 5f;
    public bool playerInAttackRange;

    Enemyhealth enemyHealthScript;

    public Vector3 collisionBoxOffset;
    public Vector3 collisionBoxSize = new Vector3(1,1,1);


    // Start is called before the first frame update
    private void Awake()
    {
        playerCharacter = GameObject.Find("FPS player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        enemyHealthScript = GetComponent<Enemyhealth>();
    }
    private void OnDrawGizmos()
    {
       // Gizmos.color = Color.yellow;
        //Gizmos.DrawWireCube(transform.position + collisionBoxOffset, collisionBoxSize);
    }

    private void Update()
    {

        if (enemyHealthScript.health > 0)
        {
            agent.SetDestination(playerCharacter.position);
        }


        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, Player);

        //CheckForPlayerCollision();

    }


    private void AttackPlayer()
    {
        if (playerInAttackRange == true)
        {
            
            print("Hit");
            /*RaycastHit hit;
            if (Physics.Raycast(playerCharacter.transform.position, playerCharacter.transform.forward, out hit, attackRange))
            {
                Debug.Log(hit.transform.name);

                Player player = hit.transform.GetComponent<Player>();
                if (player != null)
                {
                    player.PlayerTakeDamage(playerDamage);
                }


            }*/



        }
    }

    /*
    void CheckForPlayerCollision()
    {
        RaycastHit hitBox;
        if( Physics.BoxCast(transform.position + collisionBoxOffset, collisionBoxSize / 2, transform.forward, out hitBox ) )
        {
            print("enemy has hit something");
        }
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        print("collided with " + other.gameObject.tag);
        if( other.gameObject.tag == "Player")
        {
            print("collided with player");


            playerHealth.PlayerTakeDamage(5);
            print("Player has taken damage");
        }
    }



}