using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel12 : Niveles
{
    private int probCaracter;
    private int nouCaracterAdivinar;
    private int probPowerUp;
    private bool changeSpeed1;
    private bool changeSpeed2;
    private bool changeLetter;

    private void Start()
    {
        Niveles.speed = 2.0f;
        changeSpeed1 = false;
        changeSpeed2 = false;
        changeLetter = false;
    }

    void Update()
    {
        if (!gameOver && !Settings.gamePause)
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

            if (time <= 30.0f && changeLetter == false)
            {
                nouCaracterAdivinar = Random.Range(62, 89);
                valorAdivinar();
                changeLetter = true;
            }

            if (time <= 40.0f && changeSpeed1 == false)
            {
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
        GameObject p = Instantiate(prefabNumerosLetras, new Vector3(Random.Range(-7.0f, 6.0f), 5, 0), Quaternion.identity) as GameObject;

        if (time > 30.0f)
        {
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
        else if (time <= 30.0f)
        {
            switch (probCaracter)
            {
                case 3:
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[nouCaracterAdivinar];
                    p.gameObject.tag = spritesNumerosLetras[nouCaracterAdivinar].name;
                    break;
                default:
                    caracterRandom = Random.Range(62, 89);
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[caracterRandom];
                    p.gameObject.tag = spritesNumerosLetras[caracterRandom].name;
                    break;
            }
        }
    }

    public override void valorAdivinar()
    {
        if (time > 30.0f)
        {
            GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[caracterRandomAdivinar];
            tagAdivinar = spritesNumerosLetras[caracterRandomAdivinar].name;
        }
        else if (time < 30.0f)
        {
            GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[nouCaracterAdivinar];
            tagAdivinar = spritesNumerosLetras[nouCaracterAdivinar].name;
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
