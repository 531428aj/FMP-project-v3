using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Audiomanager : MonoBehaviour
{
    public static Audiomanager instance;
    private void Awake()
    {
         if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;



    public AudioClip music;
    public AudioClip sfx;
    


    private void Start()
    {
        musicSource.clip = music;
        //musicSource.Play();

        sfxSource.clip = sfx;


        if (SceneManager.GetActiveScene().name == "Menu")
        {
        }

        print("start audio manager");
    }


    public void MenuSoundStart()
    {
        musicSource.clip = music;
        musicSource.Play();
    }
    public void MenuSoundStop()
    {
        musicSource.clip = music;
        musicSource.Stop();
    }





    private void Update()
    {
      
        
    }



}


