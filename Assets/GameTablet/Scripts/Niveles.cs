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
    public GameObject rutaTutorial;
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
    public int numeroGen1;
    public int numeroGen2;
    //public int numeroGen2;

    //public string letraRandomAdivinar;
        //public int letraMinRandomAdivinar;
        //public int[] vocals = { 0, 4, 8, 14, 20 };

    //public int numeroGen1;
    //public int numeroGen2;

        //public int letraMinRandomAdivinar;  

    public string[] suma0 = {"0 + 0 = ?" };
    public string[] suma1 = {"0 + 1 = ?"};
    public string[] suma2 = {"0 + 2 = ?", "1 + 1 = ?" };
    public string[] suma3 = {"0 + 3 = ?", "2 + 2 = ?" };
    public string[] suma4 = {"0 + 4 = ?", "3 + 1 = ?", "2 + 2 = ?" };
    public string[] suma5 = {"0 + 5 = ?", "3 + 2 = ?", "1 + 4 = ?" };
    public string[] suma6 = {"0 + 6 = ?", "5 + 1 = ?", "2 + 4 = ?", "3 + 3 = ?" };
    public string[] suma7 = {"7 + 0 = ?", "6 + 1 = ?", "5 + 2 = ?", "3 + 4 = ?"};
    public string[] suma8 = {"0 + 8 = ?", "1 + 7 = ?", "6 + 2 = ?", "5 + 3 = ?", "4 + 4 = ?" };
    public string[] suma9 = {"9 + 0 = ?", "8 + 1 = ?", "7 + 2 = ?", "6 + 3 = ?", "5 + 4 = ?" };

    public string[] resta0 = {"0 - 0 = ?", "1 - 1 = ?", "2 - 2 = ?", "3 - 3 = ?", "4 - 4 = ?", "5 - 5 = ?", "6 - 6 = ?", "7 - 7 = ?", "8 - 8 = ?", "9 - 9 = ?"};
    public string[] resta1 = {"9 - 8 = ?", "8 - 7 = ?", "7 - 6 = ?", "6 - 5 = ?", "5 - 4 = ?", "4 - 3 = ?", "3 - 2 = ?", "2 - 1 = ?", "1 - 0 = ?" };
    public string[] resta2 = {"9 - 7 = ?", "8 - 6 = ?", "7 - 5 = ?", "6 - 4 = ?", "5 - 3 = ?", "4 - 2 = ?", "3 - 1 = ?", "2 - 0 = ?" };
    public string[] resta3 = {"9 - 6 = ?", "8 - 6 = ?", "7 - 4 = ?", "6 - 3 = ?", "5 - 2 = ?", "4 - 1 = ?", "3 - 0 = ?" };
    public string[] resta4 = {"9 - 5 = ?", "8 - 4 = ?", "7 - 3 = ?", "6 - 2 = ?", "5 - 1 = ?", "4 - 0 = ?" };
    public string[] resta5 = {"9 - 4 = ?", "8 - 3 = ?", "7 - 2 = ?", "6 - 1 = ?", "5 - 0 = ?" };
    public string[] resta6 = {"9 - 3 = ?", "8 - 2 = ?", "7 - 1 = ?", "6 - 0 = ?" };
    public string[] resta7 = {"9 - 2 = ?", "8 - 1 = ?", "7 - 0 = ?" };
    public string[] resta8 = {"9 - 1 = ?", "8 - 0 = ?" };
    public string[] resta9 = {"9 - 0 = ?" };


    public int vocalRandomAdivinar;
        //public int numeroRandomAdivinar;
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
        rutaTutorial = Resources.Load("Prefabs/RutaTutorial") as GameObject;


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


        numeroGen1 = UnityEngine.Random.Range(1, 10);
        numeroGen2 = UnityEngine.Random.Range(10, 20);


        //speed = 0.0f;
        //time = 999.0f;
       
        valorAdivinar();
        gameOver = false;
        Settings.gamePause = false;


        if (PlayerPrefs.GetString("Nivel") != "NivelTutorial") { GameObject.Find("textTutorial").SetActive(false); }
        


    }

    abstract public void configuration();
    abstract public void spawn();
    abstract public void valorAdivinar();
}
