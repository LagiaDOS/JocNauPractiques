using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel1 : Niveles
{
    private int probLletra;
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
            probLletra = UnityEngine.Random.Range(0, 4);
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

    public override void configuration()
    {
        Niveles.time = 60.0f;
    }

    public override void spawn()
    {
        GameObject p = Instantiate(prefabNumerosLetras, new Vector3(UnityEngine.Random.Range(-7.0f, 6.0f), 5, 0), Quaternion.identity) as GameObject;
        //p.transform.parent = canvasRender;

        switch (probLletra)
        {
            case 3:
                p.GetComponent<Text>().text = vocals[vocalRandomAdivinar];
                p.gameObject.tag = "correcte";
                //p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[vocalRandomAdivinar];
                //p.gameObject.tag = spritesNumerosLetras[vocalRandomAdivinar].name;
                break;
            default:
                //int rand = UnityEngine.Random.Range(0, 25);
                //char caracter = Convert.ToChar(rand + 65);
                //letraRandom = caracter.ToString();
                vocalRandom = UnityEngine.Random.Range(0, vocals.Length);
                p.GetComponent<Text>().text = vocals[vocalRandom];

                if (letraRandom == letraRandomAdivinar)
                {
                    p.gameObject.tag = "correcte";
                }

                //vocalRandom = vocals[UnityEngine.Random.Range(0, vocals.Length)];
                //p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[vocalRandom];
                //p.gameObject.tag = spritesNumerosLetras[vocalRandom].name;
                break;
        }
    }

    public override void valorAdivinar()
    {
        GameObject.Find("valorAdivinar").GetComponent<Text>().text = vocals[vocalRandomAdivinar];
        //tagAdivinar = spritesNumerosLetras[vocalRandomAdivinar].name;
    }

}