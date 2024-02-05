using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;
using System.Security.Cryptography;

public class NivelTutorial : Niveles {

    private int probLletra;
    private int probPowerUp;
    private float tiempoUltimaAccion;
    private float intervaloDeTiempo = 15f;
    private float timePasado = 0.0f;
    private Text tutorialText;
    private int paso = 0;
    private Text tutorialTextComp;
         
    private void Start()
    {
        GameObject.Find("textTutorial").SetActive(true);
        Niveles.speed = 2.0f;
        GameObject.Find("valorAdivinar2").GetComponent<Image>().sprite = spritesMonosilabs[20];
        Text timerText;
        timerText = GetComponent<Text>();
        timerText.text = 0.ToString("f0");


        Niveles.tutorial = true;

        tiempoUltimaAccion = Time.time;
        //myTime.meTime = 120.0f;


        GameObject.Find("textTutorial").GetComponent<Text>().text = "TEST";
        tutorialTextComp = GetComponent<Text>();


    }

    void Update()
    {
        timePasado += Time.deltaTime;

        Debug.Log("timepasado: " + timePasado);

        //primera linea tutorial in
        if (timePasado >= 0.0f && paso == 0)
        {
            //salt de linea aqui
            Debug.Log("fadein " + timePasado);
            GameObject.Find("textTutorial").GetComponent<Text>().text = "Fes servir la A i la D per a moure la nau" + " O fes servir les fletxes";
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
        if (timePasado >= 13.0f && paso == 2)
        {
            GameObject.Find("textTutorial").GetComponent<Text>().text = "Segueix la linea";
            paso++;

        }

        //segona linea tutorial out
        if (timePasado >= 17.0f && paso == 3)
        {
            GameObject.Find("textTutorial").GetComponent<Text>().text = "";
            paso++;

        }

        //minijoc seguir linea
        if (timePasado >= 18.0f && paso == 4)
        {
            GameObject p = Instantiate(rutaTutorial, new Vector3(0, 18, 0), Quaternion.identity) as GameObject;

            GameObject.Find("textTutorial").GetComponent<Text>().text = "";
            paso++;

        }

        //tercera linea tutorial in
        if (timePasado >= 55.0f && paso == 5)
        {
            //posar salt de linea
            GameObject.Find("textTutorial").GetComponent<Text>().text = "D'adalt cauran coses." + " Tens que agafar les correctes";
            paso++;

        }

        //tercera linea tutorial out
        if (timePasado >= 63.0f && paso == 6)
        {
            GameObject.Find("textTutorial").GetComponent<Text>().text = "Adalt podras veure que tens que agafar. No t'equivoquis!";
            paso++;

        }

        if (timePasado >= 70.0f && paso == 7)
        {
            GameObject.Find("textTutorial").GetComponent<Text>().text = "";
            GameObject.Find("valorAdivinar").GetComponent<Text>().text = "A";
                       
            GameObject a = Instantiate(prefabNumerosLetras, new Vector3(UnityEngine.Random.Range(-7.0f, 6.0f), 8, 0), Quaternion.identity) as GameObject;
            GameObject b = Instantiate(prefabNumerosLetras, new Vector3(UnityEngine.Random.Range(-7.0f, 6.0f), 10, 0), Quaternion.identity) as GameObject;
            GameObject c = Instantiate(prefabNumerosLetras, new Vector3(UnityEngine.Random.Range(-7.0f, 6.0f), 12, 0), Quaternion.identity) as GameObject;
            GameObject d = Instantiate(prefabNumerosLetras, new Vector3(UnityEngine.Random.Range(-7.0f, 6.0f), 14, 0), Quaternion.identity) as GameObject;
            GameObject e = Instantiate(prefabNumerosLetras, new Vector3(UnityEngine.Random.Range(-7.0f, 6.0f), 16, 0), Quaternion.identity) as GameObject;

            a.GetComponent<Text>().text = "A";
            b.GetComponent<Text>().text = "B";
            c.GetComponent<Text>().text = "A";
            d.GetComponent<Text>().text = "B";
            e.GetComponent<Text>().text = "A";

            a.gameObject.tag = "correcte";
            c.gameObject.tag = "correcte";
            e.gameObject.tag = "correcte";

            paso++;
        }

        //4ta linea tutorial in
        if (timePasado >= 85.0f && paso == 8)
        {
            GameObject.Find("textTutorial").GetComponent<Text>().text = "Ben fet! Ara vindra el joc real";
            paso++;

        }

        //4ta linea tutorial out
        if (timePasado >= 88.0f && paso == 9)
        {
            GameObject.Find("textTutorial").SetActive(false);
            GameObject.Find("textTutorial").GetComponent<Text>().text = "";
            paso++;
        }
    }
    
    public override void configuration()
    {
        Niveles.tutorial = true;
        Niveles.time = 120.0f;

    }

    public override void spawn()
    {
    }

    public override void valorAdivinar()
    {
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
