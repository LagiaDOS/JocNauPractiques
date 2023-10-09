using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Niveles : MonoBehaviour, ConfigurationLevels
{
    public GameObject prefabNumerosLetras;
    public GameObject prefabAdivinar;
    public Sprite[] spritesNumerosLetras;
    public float spwanLetrasNumros = 1;
    public int letraRandom;
    public int numeroRandom;
    public static string tagAdivinar;
    public static bool gameOver;
    public void init()
    {
        prefabNumerosLetras = Resources.Load("Prefabs/prefabNumLetras") as GameObject;
        prefabAdivinar = Resources.Load("Prefabs/prefabAdivinar") as GameObject;
        spritesNumerosLetras = Resources.LoadAll<Sprite>("Sprites/LetrasNumeros");
        letraRandom = Random.Range(0, 27);
        numeroRandom = Random.Range(28, 37);
        valorAdivinar();
        gameOver = false;
        Settings.gamePause = false;
    }
    
    abstract public void configuration();
    abstract public void spawn();
    abstract public void valorAdivinar();
}
