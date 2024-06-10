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

    [SerializeField] AudioSource gunShotSource;
    [SerializeField] AudioSource swordSlashSource;
    [SerializeField] AudioSource clickSource;



    public AudioClip gunShot;
    public AudioClip swordSlash;
    public AudioClip click;



    public void Start()
    {
        gunShotSource.clip = gunShot;
        //musicSource.Play();

        swordSlashSource.clip = swordSlash;
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
    public void AudioWhenShot()
    {
        gunShotSource.Play();
    }
    void WhenSlash()
    {
        gunShotSource.Play();
    }




}


