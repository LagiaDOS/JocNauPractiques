using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel9 : Niveles
{
    private int colorLletra;
    private int nouColorAdivinar;
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
            colorLletra = Random.Range(0, 4);
            probPowerUp = UnityEngine.Random.Range(0, 2);

            if (spawnLetrasNumros <= 0.0f)
            {
                spawn();
                spawnLetrasNumros = 1f;
            }

            if (time <= 30.0f && changeLetter == false)
            {
                nouColorAdivinar = Random.Range(90, 96);
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
        GameObject p = Instantiate(prefabNumerosLetras, new Vector3(Random.Range(-8.0f, 8.0f), 5, 0), Quaternion.identity) as GameObject;

        if (time > 30.0f)
        {
            switch (colorLletra)
            {
                case 3:
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[colorRandomAdivinar];
                    p.gameObject.tag = spritesNumerosLetras[colorRandomAdivinar].name;
                    break;
                default:
                    colorRandom = Random.Range(90, 96);
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[colorRandom];
                    p.gameObject.tag = spritesNumerosLetras[colorRandom].name;
                    break;
            }
        }
        else if (time <= 30.0f)
        {
            switch (colorLletra)
            {
                case 3:
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[nouColorAdivinar];
                    p.gameObject.tag = spritesNumerosLetras[nouColorAdivinar].name;
                    break;
                default:
                    colorRandom = Random.Range(90, 96);
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[colorRandom];
                    p.gameObject.tag = spritesNumerosLetras[colorRandom].name;
                    break;
            }
        }
    }

    public override void valorAdivinar()
    {
        if (time > 30.0f)
        {
            GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[colorRandomAdivinar];
            tagAdivinar = spritesNumerosLetras[colorRandomAdivinar].name;
        }
        else if (time < 30.0f)
        {
            GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[nouColorAdivinar];
            tagAdivinar = spritesNumerosLetras[nouColorAdivinar].name;
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
