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
        GameObject p = Instantiate(prefabNumerosLetras, new Vector3(UnityEngine.Random.Range(-6.0f, 5.0f), 5, 0), Quaternion.identity) as GameObject;
        //p.transform.parent = canvasRender;

        switch (probLletra)
        {
            case 3:
                p.GetComponent<Text>().text = vocals[vocalAdivinar];

                if (monosilabRandomAdivinar == 1 || monosilabRandomAdivinar == 3 ||
                    monosilabRandomAdivinar == 5 || monosilabRandomAdivinar == 6)
                {

                    vocalAdivinar = 0;
                    p.gameObject.tag = "correcte";

                }
                else if (monosilabRandomAdivinar == 7 || monosilabRandomAdivinar == 10 ||
                         monosilabRandomAdivinar == 13 || monosilabRandomAdivinar == 15 || monosilabRandomAdivinar == 16)
                {

                    vocalAdivinar = 1;
                    p.gameObject.tag = "correcte";

                }
                else if (monosilabRandomAdivinar == 9 || monosilabRandomAdivinar == 11 || monosilabRandomAdivinar == 18)
                {

                    vocalAdivinar = 2;
                    p.gameObject.tag = "correcte";

                }
                else if (monosilabRandomAdivinar == 0 || monosilabRandomAdivinar == 2 ||
                          monosilabRandomAdivinar == 4 || monosilabRandomAdivinar == 19)
                {

                    vocalAdivinar = 3;
                    p.gameObject.tag = "correcte";

                }
                else if (monosilabRandomAdivinar == 8 || monosilabRandomAdivinar == 12 ||
                          monosilabRandomAdivinar == 14 || monosilabRandomAdivinar == 17)
                {

                    vocalAdivinar = 4;
                    p.gameObject.tag = "correcte";

                }

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