using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monosilabs : MonoBehaviour
{
    public GameObject prefabAdivinar;

    // Llista de monosíl·labs senzills per a nens
    public string[] monosilabs = { "S_L ☀", "N_S 👃", "G_T 🥛", "BL_NC ⬜", "FL_R 🌼", "G_LL 🐓", "S_L 🧂", "G_L 🧊", "F_L 🧵" }; // Afegiu més monosíl·labs segons necessiteu


    // Funció per generar una paraula monosíl·làbica aleatòria
    public string dictarMonosilab()
    {
        int index = UnityEngine.Random.Range(0, monosilabs.Length);
        return monosilabs[index];
    }

    public void spawnParaulaMonosilabica()
    {
        string paraula = dictarMonosilab();
        GameObject adivinar = Instantiate(prefabAdivinar, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        adivinar.GetComponent<Text>().text = paraula;
    }

}
