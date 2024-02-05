using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;
using System.Security.Cryptography;



public class tutorialText : MonoBehaviour {

    private int probLletra;
    private int probPowerUp;
    private float tiempoUltimaAccion;
    private float intervaloDeTiempo = 15f;
    private float timePasado = 0.0f;
    private Text tutorialTextComp;
    private int paso = 0;


    public GameObject rutaTutorial;

    // Use this for initialization
    void Start () {
        rutaTutorial = Resources.Load("Prefabs/RutaTutorial") as GameObject;

        GameObject.Find("textTutorial").GetComponent<Text>().text = "TEST";
        tutorialTextComp = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timePasado += Time.deltaTime;

        Debug.Log("timepasado: " + timePasado);

        //primera linea tutorial in
        if (timePasado >= 0.0f && paso == 0)
        {
            //salt de linea aqui
            Debug.Log("fadein " + timePasado);
            GameObject.Find("textTutorial").GetComponent<Text>().text = "Fes servir la A i la D per a moure la nau" + "O fes servir les fletxes";
            FadeTextToFullAlpha(3f, tutorialTextComp);
            paso++;
        }

        //primera linea tutorial out
        if (timePasado >= 10.0f && paso == 1)
        {
            GameObject.Find("textTutorial").GetComponent<Text>().text = "";
            FadeTextToZeroAlpha(3f, tutorialTextComp);
            paso++;
        }

        //segona linea tutorial in
        if (timePasado >= 20.0f && paso == 2)
        {
            GameObject.Find("textTutorial").GetComponent<Text>().text = "Segueix la linea";
            paso++;

        }

        //segona linea tutorial out
        if (timePasado >= 30.0f && paso == 3)
        {
            GameObject.Find("textTutorial").GetComponent<Text>().text = "";
            paso++;

        }

        //minijoc seguir linea
        if (timePasado >= 40.0f && paso == 4)
        {
            GameObject p = Instantiate(rutaTutorial, new Vector3(0, 5, 0), Quaternion.identity) as GameObject;

            GameObject.Find("textTutorial").GetComponent<Text>().text = "";
            paso++;

        }

        //tercera linea tutorial in
        if (timePasado >= 50.0f && paso == 5)
        {
            //posar salt de linea
            GameObject.Find("textTutorial").GetComponent<Text>().text = "D'adalt cauran coses" + "Tens que agafar les correctes";
            paso++;

        }

        //tercera linea tutorial out
        if (timePasado >= 60.0f && paso == 6)
        {
            GameObject.Find("textTutorial").GetComponent<Text>().text = "";
            paso++;

        }

        //minijoc agafar coses cauen
        if (timePasado >= 70.0f && paso == 7)
        {
            GameObject.Find("textTutorial").GetComponent<Text>().text = "Paso 7";
            paso++;

        }

        //4ta linea tutorial in
        if (timePasado >= 80.0f && paso == 8)
        {
            GameObject.Find("textTutorial").GetComponent<Text>().text = "Ben fet! Ara vindra el joc real";
            paso++;

        }

        //4ta linea tutorial out
        if (timePasado >= 90.0f && paso == 9)
        {
            GameObject.Find("textTutorial").GetComponent<Text>().text = "";
            paso++;

        }

    }


    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }




}



