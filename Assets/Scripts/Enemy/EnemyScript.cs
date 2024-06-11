
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{

    public NavMeshAgent agent;

    public Transform playerCharacter;

    public LayerMask Ground, Player;

    public Player playerHealth;

    public float attackLength = 2f;

    public float attackTime;
    bool hasAttacked;

    Animator anim;
    [SerializeField] AudioSource swordSlashSource;

    public float attackRange = 10f;
    public float playerDamage = 5f;
    public bool playerInAttackRange;

    Enemyhealth enemyHealthScript;
    Player playerKilled;
    AudioManager audioManager;

    public AudioClip swordSlash;

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
        playerKilled = GetComponent<Player>();
        anim = GetComponent<Animator>();
        audioManager = GetComponent<AudioManager>();
        swordSlashSource.clip = swordSlash;
    }
    void SlashPressed()
    {
        swordSlashSource.Play();
    }


    private void Update()
    {
        print("enemy health=" + enemyHealthScript.health);

        if (enemyHealthScript.health <= 0)
        {
            
            
            anim.SetBool("Dead", true);
            
            print("Enemy killed");
        }
        else
        {
            print("enemy move to player pos");
            agent.SetDestination(playerCharacter.position);
        }


        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, Player);

        

    }




    private void OnTriggerEnter(Collider other)
    {
        print("collided with " + other.gameObject.tag);
        if( other.gameObject.tag == "Player")
        {
            print("collided with player");
            
            anim.SetBool("Attack", true);
            playerHealth.PlayerTakeDamage(5);
            print("Player has taken damage");

        }
    }

    void OnStateExit()
    {
        anim.SetBool("Attack", false);
    }


}