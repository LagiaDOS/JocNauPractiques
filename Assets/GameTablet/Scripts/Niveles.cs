using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Niveles : MonoBehaviour, ConfigurationLevels
{
    public GameObject prefabNumerosLetras;
    public GameObject prefabAdivinar;
    public GameObject prefabSpeedUp;
    public GameObject prefabSpeedDown;
    public Canvas canvasRender;

    public Sprite[] spritesNumerosLetras;
    public Sprite[] spritesNumerosDosUnidades;
    public Sprite[] spritesMonosilabs;
    public float spawnLetrasNumros = 1;
    public float spawnPowerUp = 15;
    public float changeVocal = 12;


    public string letraRandomAdivinar;
        public int letraMinRandomAdivinar;
        public string[] vocals = { "A", "E", "I", "O", "U" };
        public string[] monosilabs = { "S_L", "N_S", "G_T", "BL_NC", "FL_R", "G_LL", "S_L",
                                 "G_L", "F_LL", "N_T", "N_U", "N_U", "O_", "R_I",
                                 "S_C", "V_U", "V_NT", "_LL", "PE_X", "N_I" };
        public int monosilabRandomAdivinar;
        public int vocalAdivinar;
        public int numeroRandomAdivinar;
        public int caracterRandomAdivinar;
        public int colorRandomAdivinar;
        public int numeroLletraRandomAdivinar;
        public int numeroDosUnidadesRandomAdivinar;

        public int vocalRandom;
        public int monosilabRandom;
        public string letraRandom;
        public int letraMinRandom;
        public int numeroRandom;
        public int caracterRandom;
        public int colorRandom;
        public int numeroDosUnidadesRandom;

    public static float time;
    public static float speed;
    
    public static string tagAdivinar;
    public static bool gameOver;
    public static bool cambi = false;

    public void init()
    {
        int rand = 0;
        char caracter = 'e';
        prefabNumerosLetras = Resources.Load("Prefabs/prefabNumLetras") as GameObject;
        prefabAdivinar = Resources.Load("Prefabs/prefabAdivinar") as GameObject;
        prefabSpeedUp = Resources.Load("Prefabs/prefabSpeedUp") as GameObject;
        prefabSpeedDown = Resources.Load("Prefabs/prefabSpeedDown") as GameObject;

        spritesMonosilabs = Resources.LoadAll<Sprite>("Sprites/MonosilabIcons");
        //spritesNumerosLetras = Resources.LoadAll<Sprite>("Sprites/LetrasNumeros/NumerosLetras");
        //spritesNumerosDosUnidades = Resources.LoadAll<Sprite>("Sprites/LetrasNumeros/NumerosDosUnidades");

        rand = UnityEngine.Random.Range(0, 25);
        caracter = Convert.ToChar(rand + 65);
        letraRandomAdivinar = caracter.ToString();


        //letraMinRandomAdivinar = Random.Range(26, 51);
        monosilabRandomAdivinar = UnityEngine.Random.Range(0, monosilabs.Length);
        //vocalAdivinar = UnityEngine.Random.Range(0, vocals.Length);
        numeroRandomAdivinar = UnityEngine.Random.Range(52, 61);
        caracterRandomAdivinar = UnityEngine.Random.Range(62, 89);
        colorRandomAdivinar = UnityEngine.Random.Range(90, 96);
        numeroDosUnidadesRandomAdivinar = UnityEngine.Random.Range(0, 89);

        numeroLletraRandomAdivinar = UnityEngine.Random.Range(0, 34);
        //numeroLletraRandomAdivinar = 34;
        //Debug.Log("Numero lletra random adivinar pre calcul" + numeroLletraRandomAdivinar, gameObject);
        if (numeroLletraRandomAdivinar >= 25) { numeroLletraRandomAdivinar = numeroLletraRandomAdivinar + 27; }
        //Debug.Log("Numero lletra random adivinar post calcul" + numeroLletraRandomAdivinar, gameObject);


        rand = UnityEngine.Random.Range(0, 25);
        caracter = Convert.ToChar(rand + 65);
        letraRandom = caracter.ToString();

        letraMinRandom = UnityEngine.Random.Range(26, 51);
        numeroRandom = UnityEngine.Random.Range(52, 61);
        caracterRandom = UnityEngine.Random.Range(62, 89);
        colorRandom = UnityEngine.Random.Range(90, 96);
        numeroDosUnidadesRandom = UnityEngine.Random.Range(0, 89);

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
