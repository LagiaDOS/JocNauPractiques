using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    private ConfigurationLevels cgl;
    public static GameController instance;

    public AudioSource audioSource;
    public AudioSource audioSourceCambi;

    public AudioClip audioFacil; 
    public AudioClip audioMitja;
    public AudioClip audioDificil;
    public AudioClip audioCambi;
    private Boolean cambiLocal = false;


    //posa la instancia en el nivell actual. Si per algun motiu hi ha una creada, la elimina.
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        //agafa el string de Nivel de PlayerPrefs, i despres carrega el scrip del nivell corresponent.
        switch (PlayerPrefs.GetString("Nivel"))
        {
            case "Nivel1":
                instance.cgl = instance.gameObject.AddComponent<Nivel1>();
                audioSource.clip = audioFacil;
                break;

            case "Nivel2":
                instance.cgl = instance.gameObject.AddComponent<Nivel2>();
                audioSource.clip = audioMitja;
                break;

            case "Nivel3":
                instance.cgl = instance.gameObject.AddComponent<Nivel3>();
                audioSource.clip = audioDificil;
                break;

            case "Nivel4":
                instance.cgl = instance.gameObject.AddComponent<Nivel4>();
                audioSource.clip = audioFacil;
                break;

            case "Nivel5":
                instance.cgl = instance.gameObject.AddComponent<Nivel5>();
                audioSource.clip = audioMitja;
                break;

            case "Nivel6":
                instance.cgl = instance.gameObject.AddComponent<Nivel6>();
                audioSource.clip = audioDificil;
                break;

            case "Nivel7":
                instance.cgl = instance.gameObject.AddComponent<Nivel7>();
                audioSource.clip = audioFacil;
                break;

            case "Nivel8":
                instance.cgl = instance.gameObject.AddComponent<Nivel8>();
                audioSource.clip = audioMitja;
                break;

            case "Nivel9":
                instance.cgl = instance.gameObject.AddComponent<Nivel9>();
                audioSource.clip = audioDificil;
                break;

            case "Nivel10":
                instance.cgl = instance.gameObject.AddComponent<Nivel10>();
                audioSource.clip = audioFacil;
                break;

            case "Nivel11":
                instance.cgl = instance.gameObject.AddComponent<Nivel11>();
                audioSource.clip = audioMitja;
                break;

            case "Nivel12":
                instance.cgl = instance.gameObject.AddComponent<Nivel12>();
                audioSource.clip = audioDificil;
                break;
        }
        instance.cgl.init();
        audioSource.Play();
    }


    private void Update()
    {
        if (cambiLocal == false && Niveles.cambi == true) {

            audioSourceCambi.Play();
            cambiLocal = true;

        }

    }
}

