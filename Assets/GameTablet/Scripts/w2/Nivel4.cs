using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel4 : Niveles
{
    private int probNumero;
    private int probPowerUp;
    private float changeOperacion= 15f;

    private int sumaResta;
    private int numeroArray;
    


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
            changeOperacion -= Time.deltaTime;
            probNumero = UnityEngine.Random.Range(0, 4);
            probPowerUp = UnityEngine.Random.Range(0, 2);

            if (spawnLetrasNumros <= 0.0f)
            {
                spawn();
                spawnLetrasNumros = 1f;
            }

            //if (spawnPowerUp <= 0.0f)
            //{
            //    spawnPowerup();
           //     spawnPowerUp = 15f;
           // }
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

        //decidir si es fa una suma o no
        //escollir el numero resposta
        //escollim una de les operacions i la posem al hud
        //generem 4 numeros aleatoris (un correcte) per agafar





        GameObject p = Instantiate(prefabNumerosLetras, new Vector3(UnityEngine.Random.Range(-7.0f, 6.0f), 5, 0), Quaternion.identity) as GameObject;

        switch (probNumero)
        {
            case 3:
                //p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[numeroRandomAdivinar];
                //p.gameObject.tag = spritesNumerosLetras[numeroRandomAdivinar].name;
                break;
            default:
               // numeroRandom = Random.Range(52, 61);
               // p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[numeroRandom];
               // p.gameObject.tag = spritesNumerosLetras[numeroRandom].name;
                break;
        }

    }

    public override void valorAdivinar()
    {
        //GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[numeroRandomAdivinar];
        //tagAdivinar = spritesNumerosLetras[numeroRandomAdivinar].name;
    }
}