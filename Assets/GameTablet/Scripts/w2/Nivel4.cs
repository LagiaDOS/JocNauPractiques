using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel4 : Niveles
{
    private int probNumero;

    private void Start()
    {
        Niveles.speed = 2.0f;
    }

    void Update()
    {

        if (gameOver == false && !Settings.gamePause)
        {

            spawnLetrasNumros -= Time.deltaTime;
            probNumero = UnityEngine.Random.Range(0, 4);
            // Debug.Log(probPowerUp,gameObject);

            if (spawnLetrasNumros <= 0.0f)
            {
                spawn();
                spawnLetrasNumros = 1f;
            }


            
            if (time <= 40.0f)
            {
               // Debug.Log(time, gameObject);
               // Niveles.speed = 6.0f;
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

        switch (probNumero)
        {
            case 3:
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[numeroRandomAdivinar];
                p.gameObject.tag = spritesNumerosLetras[numeroRandomAdivinar].name;
                //Debug.Log(numeroRandomAdivinar, gameObject);
                break;
            default:
                numeroRandom = vocals[UnityEngine.Random.Range(0, vocals.Length)];
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[numeroRandom];
                p.gameObject.tag = spritesNumerosLetras[numeroRandom].name;
                //Debug.Log(numeroRandom, gameObject);
                break;
        }

    }

    public override void valorAdivinar()
    {
        GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[numeroRandomAdivinar];
        tagAdivinar = spritesNumerosLetras[numeroRandomAdivinar].name;
    }
}