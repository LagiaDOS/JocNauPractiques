using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Niveles : MonoBehaviour, ConfigurationLevels
{
    public GameObject prefabNumerosLetras;
    public GameObject prefabAdivinar;
    public GameObject prefabSpeedUp;
    public GameObject prefabSpeedDown;
    public Sprite[] spritesNumerosLetras;
    public Sprite[] spritesNumerosDosUnidades;
    public float spawnLetrasNumeros = 1;
    public float spawnPowerUp = 15;

        public int letraRandomAdivinar;
        public int letraMinRandomAdivinar;
        public int[] vocals = { 0, 4, 8, 14, 20 };
        public int vocalRandomAdivinar;
        public int numeroRandomAdivinar;
        public int caracterRandomAdivinar;
        public int colorRandomAdivinar;
        public int numeroLletraRandomAdivinar;
        public int numeroDosUnidadesRandomAdivinar;

        public int vocalRandom;
        public int letraRandom;
        public int letraMinRandom;
        public int numeroRandom;
        public int caracterRandom;
        public int colorRandom;
        public int numeroDosUnidadesRandom;



    public static float time;
    public static float speed;
    
    public static string tagAdivinar;
    public static bool gameOver;

    public void init()
    {
        prefabNumerosLetras = Resources.Load("Prefabs/prefabNumLetras") as GameObject;
        prefabAdivinar = Resources.Load("Prefabs/prefabAdivinar") as GameObject;
        prefabSpeedUp = Resources.Load("Prefabs/prefabSpeedUp") as GameObject;
        prefabSpeedDown = Resources.Load("Prefabs/prefabSpeedDown") as GameObject;

        spritesNumerosLetras = Resources.LoadAll<Sprite>("Sprites/LetrasNumeros/NumerosLetras");
        spritesNumerosDosUnidades = Resources.LoadAll<Sprite>("Sprites/LetrasNumeros/NumerosDosUnidades");



        letraRandomAdivinar = Random.Range(0, 25);
        letraMinRandomAdivinar = Random.Range(26, 51);
        vocalRandomAdivinar = vocals[Random.Range(0, vocals.Length)];
        numeroRandomAdivinar = Random.Range(52, 61);
        caracterRandomAdivinar = Random.Range(62, 89);
        colorRandomAdivinar = Random.Range(90, 96);
        numeroDosUnidadesRandomAdivinar = Random.Range(0, 89);



        numeroLletraRandomAdivinar = Random.Range(0, 34);
        //numeroLletraRandomAdivinar = 34;
        //Debug.Log("Numero lletra random adivinar pre calcul" + numeroLletraRandomAdivinar, gameObject);
        if (numeroLletraRandomAdivinar >= 25) { numeroLletraRandomAdivinar = numeroLletraRandomAdivinar + 27; }
        //Debug.Log("Numero lletra random adivinar post calcul" + numeroLletraRandomAdivinar, gameObject);


        letraRandom = Random.Range(0, 25);
        letraMinRandom = Random.Range(26, 51);
        numeroRandom = Random.Range(52, 61);
        caracterRandom = Random.Range(62, 89);
        colorRandom = Random.Range(90, 96);
        numeroDosUnidadesRandom = Random.Range(0, 89);

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
