using System.Collections;
using System.Collections.Generic;
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
            // Debug.Log(probNumero,gameObject);
            probPowerUp = UnityEngine.Random.Range(0, 2);


            if (spawnLetrasNumros <= 0.0f)
            {
                spawn();
                spawnLetrasNumros = 1f;
            }

            if (time <= 30.0f && changeNumber == false)
            {
                Debug.Log("canvi lletra", gameObject);
                Debug.Log(changeNumber, gameObject);
                Debug.Log(numeroRandomAdivinar, gameObject);

                nouNumeroAdivinar = Random.Range(0, 25);
                valorAdivinar();

                Debug.Log(nouNumeroAdivinar, gameObject);

                //GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[nouNumeroAdivinar];
                //tagAdivinar = spritesNumerosLetras[nouNumeroAdivinar].name;

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
                // Debug.Log(time, gameObject);
                Niveles.speed = 4.0f;
                changeSpeed2 = true;
            }

            if (spawnPowerUp <= 0.0f)
            {
                //Debug.Log("Spawn powerup", gameObject);
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
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[numeroRandomAdivinar];
                    p.gameObject.tag = spritesNumerosLetras[numeroRandomAdivinar].name;
                    break;
                default:
                    numeroRandom = Random.Range(52, 61);
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
                    numeroRandom = Random.Range(52, 61);
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
            Debug.Log("lletra 1 adivinar", gameObject);

            GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[numeroRandomAdivinar];
            tagAdivinar = spritesNumerosLetras[numeroRandomAdivinar].name;
        }
        else if (time < 30.0f)
        {
            Debug.Log("lletra 2 adivinar", gameObject);

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
