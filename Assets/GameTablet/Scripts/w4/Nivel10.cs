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

        switch (probCaracter)
        {
            case 3:
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[caracterRandomAdivinar];
                p.gameObject.tag = spritesNumerosLetras[caracterRandomAdivinar].name;
                //Debug.Log(caracterRandomAdivinar, gameObject);
                break;
            default:
                caracterRandom = vocals[UnityEngine.Random.Range(0, vocals.Length)];
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[caracterRandom];
                p.gameObject.tag = spritesNumerosLetras[caracterRandom].name;
                //Debug.Log(caracterRandom, gameObject);
                break;
        }

    }

    public override void valorAdivinar()
    {
        GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[caracterRandomAdivinar];
        tagAdivinar = spritesNumerosLetras[caracterRandomAdivinar].name;
    }
}