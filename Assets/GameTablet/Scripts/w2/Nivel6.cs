using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Nivel6 : Niveles
{
    private int probNumero;
    private int nouNumeroAdivinar;
    private int probPowerUp;
    private bool changeSpeed1;
    private bool changeSpeed2;
    private bool changeNumber;

    private void Start()
    {
        Niveles.speed = 2.0f;
        changeSpeed1 = false;
        changeSpeed2 = false;
        changeNumber = false;
    }

    void Update()
    {
        if (!gameOver && !Settings.gamePause)
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

            if (time <= 30.0f && changeNumber == false)
            {
                nouNumeroAdivinar = Random.Range(0, 36);
                if (nouNumeroAdivinar >= 26) { nouNumeroAdivinar = +26; }
                valorAdivinar();
                GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[nouNumeroAdivinar];
                tagAdivinar = spritesNumerosLetras[nouNumeroAdivinar].name;
                changeNumber = true;
            }

            if (time <= 40.0f && changeSpeed1 == false)
            {
                // Debug.Log(time, gameObject);
                Niveles.speed = 3.0f;
                changeSpeed1 = true;
            }

            if (time <= 20.0f && changeSpeed2 == false)
            {
                Niveles.speed = 4.0f;
                changeSpeed2 = true;
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

        if (time > 30.0f)
        {
            switch (probNumero)
            {
                case 3:
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[numeroLletraRandomAdivinar];
                    p.gameObject.tag = spritesNumerosLetras[numeroLletraRandomAdivinar].name;
                    break;

                default:
                    numeroRandom = Random.Range(0, 34);
                    if (numeroRandom >= 25) { numeroRandom = numeroRandom + 27; }
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[numeroRandom];
                    p.gameObject.tag = spritesNumerosLetras[numeroRandom].name;
                    break;
            }
        }
        else if (time <= 30.0f)
        {
            switch (probNumero)
            {
                case 3:
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[nouNumeroAdivinar];
                    p.gameObject.tag = spritesNumerosLetras[nouNumeroAdivinar].name;
                    break;
                default:
                    numeroRandom = Random.Range(0, 34);
                    if (numeroRandom >= 25) { numeroRandom = numeroRandom + 27; }
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[numeroRandom];
                    p.gameObject.tag = spritesNumerosLetras[numeroRandom].name;
                    break;
            }
        }
    }

    public override void valorAdivinar()
    {
        if (time > 30.0f)
        {
            GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[numeroLletraRandomAdivinar];
            tagAdivinar = spritesNumerosLetras[numeroLletraRandomAdivinar].name;
        }
        else if (time < 30.0f)
        {
            GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[nouNumeroAdivinar];
            tagAdivinar = spritesNumerosLetras[nouNumeroAdivinar].name;
        }
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



