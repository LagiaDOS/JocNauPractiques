using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel10 : Niveles
{
    private int probCaracter;

    private void Start()
    {
        Niveles.speed = 2.0f;
    }

    void Update()
    {
        if (gameOver == false && !Settings.gamePause)
        {
            spawnLetrasNumros -= Time.deltaTime;
            probCaracter = UnityEngine.Random.Range(0, 4);

            if (spawnLetrasNumros <= 0.0f)
            {
                spawn();
                spawnLetrasNumros = 1f;
            }
        }
    }
    
    public override void configuration()
    {
        Niveles.time = 60.0f;
    }

    public override void spawn()
    {
        GameObject p = Instantiate(prefabNumerosLetras, new Vector3(UnityEngine.Random.Range(-7.0f, 6.0f), 5, 0), Quaternion.identity) as GameObject;

        switch (probCaracter)
        {
            case 3:
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[caracterRandomAdivinar];
                p.gameObject.tag = spritesNumerosLetras[caracterRandomAdivinar].name;
                break;

            default:
                caracterRandom = UnityEngine.Random.Range(62, 89);
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

}