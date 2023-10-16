using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Niveles : MonoBehaviour, ConfigurationLevels
{
    public GameObject prefabNumerosLetras;
    public GameObject prefabAdivinar;
    public Sprite[] spritesNumerosLetras;
    public float spawnLetrasNumros = 1;

        public int letraRandomAdivinar;
        public int letraMinRandomAdivinar;
        public int numeroRandomAdivinar;
        public int caracterRandomAdivinar;
        public int letraRandom;
        public int letraMinRandom;
        public int numeroRandom;
        public int caracterRandom;

    public static float time;
    public static float speed;

    public static string tagAdivinar;
    public static bool gameOver;

    public void init()
    {
        prefabNumerosLetras = Resources.Load("Prefabs/prefabNumLetras") as GameObject;
        prefabAdivinar = Resources.Load("Prefabs/prefabAdivinar") as GameObject;
        spritesNumerosLetras = Resources.LoadAll<Sprite>("Sprites/LetrasNumeros");

        letraRandomAdivinar = Random.Range(0, 25);
        letraMinRandomAdivinar = Random.Range(26, 51);
        numeroRandomAdivinar = Random.Range(52, 61);
        caracterRandomAdivinar = Random.Range(62, 88);

        letraRandom = Random.Range(0, 25);
        letraMinRandom = Random.Range(26, 51);
        numeroRandom = Random.Range(52, 61);
        caracterRandom = Random.Range(62, 88);

        speed = 0.0f;
        time = 999.0f;
       
        valorAdivinar();
        gameOver = false;
        Settings.gamePause = false;
    }
    
    abstract public void configuration();
    abstract public void spawn();
    abstract public void valorAdivinar();
}
