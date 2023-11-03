using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myTime : MonoBehaviour {
    //Variables para el tiempo
    public float meTime;       // -----> Tiempo que dura el juego
    private Text timerText;         // -----> Texto donde se guarda el tiempo
    public GameObject gameOver;

	// Use this for initialization
	void Start () {
        //meTime = 60.0f;

        //depenent el nivell en el que estem, el temps disponible pot cambiar
        switch (PlayerPrefs.GetString("Nivel"))
        {
            default:
                meTime = 60f;
                break;


        }
        timerText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!Niveles.gameOver && !Settings.gamePause)
        {
            //redueix el temps en 1 cada 1 segon
                meTime -= Time.deltaTime;
                Niveles.time = meTime;

            //si el temps arriba a 0, acaba la partida
                timerText.text = meTime.ToString("f0");
                if (meTime <= 0)
                {
                    gameOver.gameObject.SetActive(true);
                    Niveles.gameOver = true;
                }
        }  
	}
}
