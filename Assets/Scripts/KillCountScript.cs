
using UnityEngine;
using UnityEngine.SceneManagement;
public class Killcountscript : MonoBehaviour

{
    public static int EnemiesLeft = 0;
    public float EnemiesAlive = EnemiesLeft;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemiesLeft == 40)
        {
            EnemiesLeft -= EnemiesLeft;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
