﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel11 : Niveles
{
    private int probCaracter;
    private int probPowerUp;

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
            probCaracter = Random.Range(0, 4);
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

        }
    }

    public override void configuration()
    {
        Niveles.time = 60.0f;
    }

    public override void spawn()
    {
        GameObject p = Instantiate(prefabNumerosLetras, new Vector3(Random.Range(-8.0f, 8.0f), 5, 0), Quaternion.identity) as GameObject;

        switch (probCaracter)
        {
            case 3:
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[caracterRandomAdivinar];
                p.gameObject.tag = spritesNumerosLetras[caracterRandomAdivinar].name;
                break;
            default:
                caracterRandom = Random.Range(62, 89);
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[caracterRandom];
                p.gameObject.tag = spritesNumerosLetras[caracterRandom].name;
                break;
        }
    }

    public override void valorAdivinar()
    {
        GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[caracterRandomAdivinar];
        tagAdivinar = spritesNumerosLetras[caracterRandomAdivinar].name;
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
