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
    public string DictarMonosilab()
    {
        int index = UnityEngine.Random.Range(0, monosilabs.Length);
        return monosilabs[index];
    }

    // Funció per instanciar un prefabAdivinar amb la paraula generada
    public void SpawnParaulaMonosilabica()
    {
        string paraula = dictarMonosilab();
        GameObject adivinar = Instantiate(prefabAdivinar, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        adivinar.GetComponent<Text>().text = paraula;
    }

    public void DictarVocalCorrecta(string paraula)
    {
        int index = paraula.IndexOf('_');
        if (index != -1 && index < paraula.Length - 1)
        {
            return paraula[index + 1];
        }
        return '\0'; // Retorna un caràcter nul si no es pot determinar la vocal correcta
    }
}
