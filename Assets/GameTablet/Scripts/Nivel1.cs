﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel1 : Niveles
{
    private int probLletra;

    private void Start()
    {
        Niveles.speed = 2.0f;

    }

    void Update()
    {

        if (gameOver == false && !Settings.gamePause)
        {

            spawnLetrasNumros -= Time.deltaTime;
            probLletra = Random.Range(0, 4);
            // Debug.Log(probLletra,gameObject);

            if (spawnLetrasNumros <= 0.0f)
            {
                spawn();
                spawnLetrasNumros = 1f;
            }

            if (time <= 40.0f)
            {
                Debug.Log(time, gameObject);
            }

        }

    }
    public override void configuration()
    {
        Niveles.time = 60.0f;
    }

    public override void spawn()
    {
        GameObject p = Instantiate(prefabNumerosLetras, new Vector3(Random.Range(-3.0f, 2.0f), 5, 0), Quaternion.identity) as GameObject;

        switch (probLletra)
        {
            case 3:
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[vocalRandomAdivinar];
                p.gameObject.tag = spritesNumerosLetras[vocalRandomAdivinar].name;
                Debug.Log(vocalRandomAdivinar, gameObject);
                break;
            default:
                vocalRandom = vocals[Random.Range(0, vocals.Length)];
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[vocalRandom];
                p.gameObject.tag = spritesNumerosLetras[vocalRandom].name;
                Debug.Log(vocalRandom, gameObject);
                break;
        }

    }
    public override void valorAdivinar()
    {
        GameObject.Find("valorAdivinar").GetComponent<Image>().sprite = spritesNumerosLetras[vocalRandomAdivinar];
        tagAdivinar = spritesNumerosLetras[vocalRandomAdivinar].name;
    }
}