﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel5 : Niveles
{
    private int probNumero;
    private int probPowerUp;
    private bool change = false;

    private void Start()
    {
        Niveles.speed = 2.0f;
    }

    void Update()
    {
        if (gameOver == false && !Settings.gamePause)
        {
            spawnLetrasNumros -= Time.deltaTime;
            spawnPowerUp -= Time.deltaTime;
            probNumero = Random.Range(0, 4);
            probPowerUp = UnityEngine.Random.Range(0, 2);

            if (spawnLetrasNumros <= 0.0f)
            {
                spawn();
                spawnLetrasNumros = 1f;
            }

            if (spawnPowerUp <= 0.0f)
            {
                spawnPowerup();
                spawnPowerUp = 15f;
            }

            if (time < 30f && change == false) {
                change = true;
                numeroGen1 = UnityEngine.Random.Range(1, 10); ;
                valorAdivinar();
                
            }

        }
    }

    public override void configuration()
    {
        Niveles.time = 60.0f;
    }

    public override void spawn()
    {
        GameObject p = Instantiate(prefabNumerosLetras, new Vector3(Random.Range(-7.0f, 6.0f), 5, 0), Quaternion.identity) as GameObject;

        switch (probNumero)
        {
            case 3:
                p.GetComponent<Text>().text = numeroGen1.ToString();
                p.gameObject.tag = "correcte";
                break;
            default:
                numeroDosUnidadesRandom = Random.Range(1, 10);
                p.GetComponent<Text>().text = numeroDosUnidadesRandom.ToString();

                if (numeroDosUnidadesRandom == numeroGen1)
                {
                    p.gameObject.tag = "correcte";
                }

                break;
        }
    }

    public override void valorAdivinar()
    {

        GameObject.Find("valorAdivinar").GetComponent<Text>().text = (numeroGen1-1).ToString() + " - ? -" + (numeroGen1 + 1).ToString();
        tagAdivinar = spritesNumerosDosUnidades[numeroDosUnidadesRandomAdivinar].name;
    }

    private void spawnPowerup()
    {
        if (probPowerUp == 0)
        {
            GameObject SU = Instantiate(prefabSpeedUp, new Vector3(UnityEngine.Random.Range(-3.0f, 2.0f), 5, 0), Quaternion.identity) as GameObject;
        }
        else
        {
            GameObject SD = Instantiate(prefabSpeedDown, new Vector3(UnityEngine.Random.Range(-3.0f, 2.0f), 5, 0), Quaternion.identity) as GameObject;
        }
    }

}
