using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    private ConfigurationLevels cgl;
    public static GameController instance;
    

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
        
        switch (PlayerPrefs.GetString("Nivel"))
        {
            case "Nivel1":
                instance.cgl = instance.gameObject.AddComponent<Nivel1>();

                break;
            case "Nivel2":
                instance.cgl = instance.gameObject.AddComponent<Nivel2>();
                break;
            case "Nivel3":
                //gameObject.AddComponent<Nivel3>();
                break;
        }
        instance.cgl.init();
    }
}

