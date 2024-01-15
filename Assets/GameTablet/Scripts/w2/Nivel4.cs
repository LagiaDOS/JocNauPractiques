using System;
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
    private int operacio;
    private string textHud;
    private int resposta;
    private int[] arrayNumeros ={0,0,0,0};


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

        //decidir si es fa una suma o no, 0 es resta, 1 es suma
        sumaResta = UnityEngine.Random.Range(0, 1);

        //escollir el numero resposta
        numeroArray = UnityEngine.Random.Range(0, 9);
        //escollim una de les operacions i la posem al hud

        if (sumaResta == 0)
        {
            //resta si es 0
            switch (numeroArray)
            {
                case 0: textHud = resta0[UnityEngine.Random.Range(0, resta0.Length)]; resposta = 0; break;
                case 1: textHud = resta1[UnityEngine.Random.Range(0, resta1.Length)]; resposta = 1; break;
                case 2: textHud = resta2[UnityEngine.Random.Range(0, resta2.Length)]; resposta = 2; break;
                case 3: textHud = resta3[UnityEngine.Random.Range(0, resta3.Length)]; resposta = 3; break;
                case 4: textHud = resta4[UnityEngine.Random.Range(0, resta4.Length)]; resposta = 4; break;
                case 5: textHud = resta5[UnityEngine.Random.Range(0, resta5.Length)]; resposta = 5; break;
                case 6: textHud = resta6[UnityEngine.Random.Range(0, resta6.Length)]; resposta = 6; break;
                case 7: textHud = resta7[UnityEngine.Random.Range(0, resta7.Length)]; resposta = 7; break;
                case 8: textHud = resta8[UnityEngine.Random.Range(0, resta8.Length)]; resposta = 8; break;
                case 9: textHud = resta9[UnityEngine.Random.Range(0, resta9.Length)]; resposta = 9; break;
            }
        }
        else {
            //suma si es 1
            switch (numeroArray)
            {
                case 0: textHud = suma0[UnityEngine.Random.Range(0, suma0.Length)]; resposta = 0; break;
                case 1: textHud = suma1[UnityEngine.Random.Range(0, suma1.Length)]; resposta = 1; break;
                case 2: textHud = suma2[UnityEngine.Random.Range(0, suma2.Length)]; resposta = 2; break;
                case 3: textHud = suma3[UnityEngine.Random.Range(0, suma3.Length)]; resposta = 3; break;
                case 4: textHud = suma4[UnityEngine.Random.Range(0, suma4.Length)]; resposta = 4; break;
                case 5: textHud = suma5[UnityEngine.Random.Range(0, suma5.Length)]; resposta = 5; break;
                case 6: textHud = suma6[UnityEngine.Random.Range(0, suma6.Length)]; resposta = 6; break;
                case 7: textHud = suma7[UnityEngine.Random.Range(0, suma7.Length)]; resposta = 7; break;
                case 8: textHud = suma8[UnityEngine.Random.Range(0, suma8.Length)]; resposta = 8; break;
                case 9: textHud = suma9[UnityEngine.Random.Range(0, suma9.Length)]; resposta = 9; break;
            }
        }
        GameObject.Find("valorAdivinar").GetComponent<Text>().text = textHud;

        //generem 4 numeros aleatoris (un correcte) per agafar

        arrayNumeros[0] = Int32.Parse(textHud);


        for (int i = 1; i == 4; i++)
        {
            while (arrayNumeros[i] == arrayNumeros[0])
            {
                arrayNumeros[i] = UnityEngine.Random.Range(0, 9);
            }
        }

        //un cop fet l'array, em el shuffle i despres creem els 4 objectes al mateix temps en 4 posicions fixes




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