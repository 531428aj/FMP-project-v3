using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Killcountscript : MonoBehaviour

{
    public static int EnemiesLeft = 40;
    public float EnemiesAlive = EnemiesLeft;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemiesLeft == 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
