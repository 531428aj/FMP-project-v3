
using UnityEngine;

public class Gunscript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera playerCam;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
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
}
