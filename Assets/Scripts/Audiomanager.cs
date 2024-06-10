using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    
    
    [SerializeField] AudioSource clickSource;



    public AudioClip gunShot;
    public AudioClip swordSlash;
    public AudioClip click;



    public void Start()
    {
        
        //musicSource.Play();

        
        clickSource.clip = click;  


        if (SceneManager.GetActiveScene().name == "Menu")
        {
        }

        print("start audio manager");
    }

    void MenuButtonPressed()
    {
        clickSource.Play();
    }






}


