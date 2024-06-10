
using UnityEngine;


public class Gunscript : MonoBehaviour
{
    [SerializeField] AudioSource gunShotSource;
    public AudioManager audioManagerScript;
       

    public float damage = 10f;
    public float range = 100f;

    public AudioClip gunShot;

    public Camera playerCam;
    Animator anim;

    


    private void Start()
    {
        gunShotSource.clip = gunShot;
        anim = GetComponent<Animator>();
       
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            
        }
        
    }
    public void Shoot()
    {
        //audioManagerScript.gunShot();

        gunShotSource.Play();
        anim.SetBool("Shot", true);
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Enemyhealth enemy = hit.transform.GetComponent<Enemyhealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            
        }
        
    }
    void Recoil()
    {
        anim.SetBool("Shot", false);
    }
}
