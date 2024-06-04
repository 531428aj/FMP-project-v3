
using UnityEngine;

public class Gunscript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera playerCam;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            
        }
        
    }
    void Shoot()
    {
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
