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
            // Debug.Log(probPowerUp,gameObject);

            if (spawnLetrasNumros <= 0.0f)
            {
                spawn();
                spawnLetrasNumros = 1f;
            }

            if (spawnPowerUp <= 0.0f)
            {
                //Debug.Log("Spawn powerup", gameObject);
                spawnPowerup();
                spawnPowerUp = 15f;
            }
            
            if (time <= 40.0f)
            {
               // Debug.Log(time, gameObject);
               // Niveles.speed = 6.0f;
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

        switch (probLletra)
        {
            case 3:
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[vocalRandomAdivinar];
                p.gameObject.tag = spritesNumerosLetras[vocalRandomAdivinar].name;
                //Debug.Log(vocalRandomAdivinar, gameObject);
                break;
            default:
                vocalRandom = vocals[UnityEngine.Random.Range(0, vocals.Length)];
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[vocalRandom];
                p.gameObject.tag = spritesNumerosLetras[vocalRandom].name;
                //Debug.Log(vocalRandom, gameObject);
                break;
        }

    }

    public override void valorAdivinar()
    {
        GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[vocalRandomAdivinar];
        tagAdivinar = spritesNumerosLetras[vocalRandomAdivinar].name;
    }
}