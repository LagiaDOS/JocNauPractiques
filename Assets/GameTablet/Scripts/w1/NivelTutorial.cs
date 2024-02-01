using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;
using System.Security.Cryptography;

public class NivelTutorial : Niveles {

    private int probLletra;
    private int probPowerUp;
    private float tiempoUltimaAccion;
    private float intervaloDeTiempo = 15f;
    private float timePasado = 0.0f;
    private Text tutorialText;
    private int paso = 0;

    private void Start()
    {

        Text timerText;
        timerText = GetComponent<Text>();
        timerText.text = 0.ToString("f0");

        Niveles.speed = 2.0f;
        Niveles.tutorial = true;

        tiempoUltimaAccion = Time.time;
        //myTime.meTime = 120.0f;
    }

    void Update()
    {

        timePasado += Time.deltaTime;
        
        //primera linea tutorial in
        if (timePasado >= 0.0f && paso == 0)
        {

        }

        //primera linea tutorial out
        if (timePasado >= 10.0f && paso == 1)
        {

        }

        //segona linea tutorial in
        if (timePasado >= 0.0f && paso == 2)
        {
        }

        //segona linea tutorial out
        if (timePasado >= 0.0f && paso == 3)
        {
        }

        //minijoc seguir linea
        if (timePasado >= 0.0f && paso == 4)
        {
        }

        //tercera linea tutorial in
        if (timePasado >= 0.0f && paso == 5)
        {
        }

        //tercera linea tutorial out
        if (timePasado >= 0.0f && paso == 6)
        {
        }

        //minijoc agafar coses cauen
        if (timePasado >= 0.0f && paso == 7)
        {
        }

        //4ta linea tutorial in
        if (timePasado >= 0.0f && paso == 8)
        {
        }

        //4ta linea tutorial out
        if (timePasado >= 0.0f && paso == 9)
        {
        }
    }


    public override void configuration()
    {
        Niveles.tutorial = true;
        Niveles.time = 120.0f;

    }

    public override void spawn()
    {
    }

    public override void valorAdivinar()
    {
    }
}
