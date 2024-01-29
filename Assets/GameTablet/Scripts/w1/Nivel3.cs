using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel3 : Niveles
{
    private int probLletra;
    private int probPowerUp;
    private bool changeSpeed1;
    private bool changeSpeed2;
    private bool changeSpawnrate1;
    private bool changeSpawnrate2;
    private float tiempoUltimaAccion;
    private float intervaloDeTiempo = 15f;


    private void Start()
    {
        Niveles.speed = 2.0f;
        tiempoUltimaAccion = Time.time;
        changeSpeed1 = false;
        changeSpeed2 = false;
        changeSpawnrate1 = false;
        changeSpawnrate2 = false;
    }

    void Update()
    {
        if (gameOver == false && !Settings.gamePause)
        {
            spawnLetrasNumros -= Time.deltaTime;
            spawnPowerUp -= Time.deltaTime;
            changeVocal -= Time.deltaTime;
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

            if (changeVocal <= 0.0f)
            {
                swapMonosilab();
                changeVocal = 12f;
            }

            if (time <= 40.0f && changeSpeed1 == false)
            {
                // Debug.Log(time, gameObject);
                Niveles.speed = 2.0f;
                changeSpeed1 = true;
                spawnLetrasNumros = 0.6f;
                changeSpawnrate1 = true;
            }

            if (time <= 20.0f && changeSpeed2 == false)
            {
                Niveles.speed = 3.0f;
                changeSpeed2 = true;
                spawnLetrasNumros = 0.4f;
                changeSpawnrate2 = true;
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

    public void swapMonosilab()
    {
        monosilabRandomAdivinar = UnityEngine.Random.Range(0, monosilabs.Length);
        if (monosilabRandomAdivinar == 1 || monosilabRandomAdivinar == 3 ||
            monosilabRandomAdivinar == 5 || monosilabRandomAdivinar == 6)
        {

            vocalAdivinar = 0;

        }
        else if (monosilabRandomAdivinar == 7 || monosilabRandomAdivinar == 10 ||
                 monosilabRandomAdivinar == 13 || monosilabRandomAdivinar == 15 || monosilabRandomAdivinar == 16)
        {

            vocalAdivinar = 1;

        }
        else if (monosilabRandomAdivinar == 9 || monosilabRandomAdivinar == 11 || monosilabRandomAdivinar == 18)
        {

            vocalAdivinar = 2;

        }
        else if (monosilabRandomAdivinar == 0 || monosilabRandomAdivinar == 2 ||
                  monosilabRandomAdivinar == 4 || monosilabRandomAdivinar == 19)
        {

            vocalAdivinar = 3;

        }
        else if (monosilabRandomAdivinar == 8 || monosilabRandomAdivinar == 12 ||
                  monosilabRandomAdivinar == 14 || monosilabRandomAdivinar == 17)
        {

            vocalAdivinar = 4;

        }

        valorAdivinar();
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

                if (monosilabRandomAdivinar == 1 || monosilabRandomAdivinar == 3 ||
                    monosilabRandomAdivinar == 5 || monosilabRandomAdivinar == 6)
                {

                    vocalAdivinar = 0;

                }
                else if (monosilabRandomAdivinar == 7 || monosilabRandomAdivinar == 10 ||
                         monosilabRandomAdivinar == 13 || monosilabRandomAdivinar == 15 || monosilabRandomAdivinar == 16)
                {

                    vocalAdivinar = 1;

                }
                else if (monosilabRandomAdivinar == 9 || monosilabRandomAdivinar == 11 || monosilabRandomAdivinar == 18)
                {

                    vocalAdivinar = 2;

                }
                else if (monosilabRandomAdivinar == 0 || monosilabRandomAdivinar == 2 ||
                          monosilabRandomAdivinar == 4 || monosilabRandomAdivinar == 19)
                {

                    vocalAdivinar = 3;

                }
                else if (monosilabRandomAdivinar == 8 || monosilabRandomAdivinar == 12 ||
                          monosilabRandomAdivinar == 14 || monosilabRandomAdivinar == 17)
                {

                    vocalAdivinar = 4;

                }

                switch (vocalAdivinar)
                {
                    case 0: //A
                        p.gameObject.tag = "correcte";

                        break;
                    case 1: // E
                        p.gameObject.tag = "correcte";

                        break;
                    case 2:  // I
                        p.gameObject.tag = "correcte";

                        break;
                    case 3:  // O
                        p.gameObject.tag = "correcte";

                        break;
                    case 4:  // U
                        p.gameObject.tag = "correcte";

                        break;
                }

                p.GetComponent<Text>().text = vocals[vocalAdivinar];

                //p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[vocalRandomAdivinar];
                //p.gameObject.tag = spritesNumerosLetras[vocalRandomAdivinar].name;
                break;
            default:
                //int rand = UnityEngine.Random.Range(0, 25);
                //char caracter = Convert.ToChar(rand + 65);
                //letraRandom = caracter.ToString();
                vocalRandom = UnityEngine.Random.Range(0, vocals.Length);
                p.GetComponent<Text>().text = vocals[vocalRandom];

                if (vocalRandom == vocalAdivinar)
                {
                    switch (vocalAdivinar)
                    {
                        case 0: //A
                            p.gameObject.tag = "correcte";

                            break;
                        case 1: // E
                            p.gameObject.tag = "correcte";

                            break;
                        case 2:  // I
                            p.gameObject.tag = "correcte";

                            break;
                        case 3:  // O
                            p.gameObject.tag = "correcte";

                            break;
                        case 4:  // U
                            p.gameObject.tag = "correcte";

                            break;
                    }
                }

                //vocalRandom = vocals[UnityEngine.Random.Range(0, vocals.Length)];
                //p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[vocalRandom];
                //p.gameObject.tag = spritesNumerosLetras[vocalRandom].name;
                break;
        }
    }

    public override void valorAdivinar()
    {
        GameObject.Find("valorAdivinar").GetComponent<Text>().text = monosilabs[monosilabRandomAdivinar];
        GameObject.Find("valorAdivinar2").GetComponent<Image>().sprite = spritesMonosilabs[monosilabRandomAdivinar];
        //tagAdivinar = spritesNumerosLetras[vocalRandomAdivinar].name;
    }

}