using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

    public NavMeshAgent agent;

    public Transform player;

    public LayerMask Ground, Player;

    public float attackTime;
    bool hasAttacked;

    public float attackRange;
    public bool playerInAttackRange;
    // Start is called before the first frame update
    private void Awake()
    {
        player = GameObject.Find("FPS player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(player.position);
    }

    private void ChasePlayer()
    {

    }
    private void AttackPlayer()
    {

    }


}
