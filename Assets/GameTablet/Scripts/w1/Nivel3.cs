using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel3 : Niveles
{
    private int probLletra;
    private int novaLletraAdivinar;

    private void Start()
    {
        Niveles.speed = 2.0f;

    }

    void Update()
    {

        if (!gameOver && !Settings.gamePause)
        {

            spawnLetrasNumros -= Time.deltaTime;
            probLletra = Random.Range(0, 4);
            // Debug.Log(probLletra,gameObject);

            if (spawnLetrasNumros <= 0.0f)
            {
                spawn();
                spawnLetrasNumros = 1f;
            }

            if(time <= 30.0f)
            {
                novaLletraAdivinar = Random.Range(0, 25);
            }

            if (time <= 40.0f)
            {
                // Debug.Log(time, gameObject);
            }

        }

    }
    public override void configuration()
    {
        Niveles.time = 60.0f;
    }

    public override void spawn()
    {
        GameObject p = Instantiate(prefabNumerosLetras, new Vector3(Random.Range(-10.0f, 9.0f), 5, 0), Quaternion.identity) as GameObject;

            if(time > 30.0f)
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
