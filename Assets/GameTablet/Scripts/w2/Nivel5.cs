using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel5 : Niveles
{
    private int probNumero;
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

            probNumero = Random.Range(0, 4);
            // Debug.Log(probNumero,gameObject);
            probPowerUp = UnityEngine.Random.Range(0, 2);


            if (spawnLetrasNumros <= 0.0f)
            {
                spawn();
                spawnLetrasNumros = 1f;
            }

            if (time <= 40.0f)
            {
                Debug.Log(time, gameObject);
            }

            if (spawnPowerUp <= 0.0f)
            {
                Debug.Log("Spawn powerup", gameObject);
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

        switch (probNumero)
        {
            case 3:
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[numeroRandomAdivinar];
                p.gameObject.tag = spritesNumerosLetras[numeroRandomAdivinar].name;
                break;
            default:
                numeroRandom = Random.Range(0, 25);
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[numeroRandom];
                p.gameObject.tag = spritesNumerosLetras[numeroRandom].name;
                break;
        }

    }
    public override void valorAdivinar()
    {
        GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[numeroRandomAdivinar];
        tagAdivinar = spritesNumerosLetras[numeroRandomAdivinar].name;
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
