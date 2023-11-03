using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel3 : Niveles
{
    private int probLletra;
    private int novaLletraAdivinar;
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
        GameObject p = Instantiate(prefabNumerosLetras, new Vector3(Random.Range(-10.0f, 9.0f), 5, 0), Quaternion.identity) as GameObject;

        if (time > 30.0f)
        {
            switch (probLletra)
            {
                case 3:
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[letraRandomAdivinar];
                    p.gameObject.tag = spritesNumerosLetras[letraRandomAdivinar].name;
                    break;
                default:
                    letraRandom = Random.Range(0, 27);
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[letraRandom];
                    p.gameObject.tag = spritesNumerosLetras[letraRandom].name;
                    break;
            }
        }
        else if (time <= 30.0f)
        {
            switch (probLletra)
            {
                case 3:
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[novaLletraAdivinar];
                    p.gameObject.tag = spritesNumerosLetras[novaLletraAdivinar].name;
                    break;
                default:
                    letraRandom = Random.Range(0, 27);
                    p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[letraRandom];
                    p.gameObject.tag = spritesNumerosLetras[letraRandom].name;
                    break;
            }
        }
    }

    public override void valorAdivinar()
    {
        if (time > 30.0f)
        {
            GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[letraRandomAdivinar];
            tagAdivinar = spritesNumerosLetras[letraRandomAdivinar].name;
        }
        else if (time < 30.0f)
        {
            GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[novaLletraAdivinar];
            tagAdivinar = spritesNumerosLetras[novaLletraAdivinar].name;
        }
    }

}
