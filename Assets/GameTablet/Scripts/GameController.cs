using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    private ConfigurationLevels cgl;
    public static GameController instance;
    

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
                break;

            case "Nivel2":
                instance.cgl = instance.gameObject.AddComponent<Nivel2>();
                break;

            case "Nivel3":
                instance.cgl = instance.gameObject.AddComponent<Nivel3>();
                break;
        }
        instance.cgl.init();
    }
}

