using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel1 : Niveles
{
    private int probLletra;

    void Update()
    {
        
        if (gameOver==false)
        {
            if (!Settings.gamePause)
            {
                spwanLetrasNumros -= Time.deltaTime;
                probLletra = Random.Range(0, 4);
                // Debug.Log(probLletra,gameObject);

                if (spwanLetrasNumros <= 0.0f)
                {
                    spawn();
                    spwanLetrasNumros = 1f;
                }
            }
        }
        
    }
    public override void configuration()
    {
        
    }
    public override void spawn()
    {
        GameObject p = Instantiate(prefabNumerosLetras, new Vector3(Random.Range(-3.0f, 2.0f), 5, 0), Quaternion.identity) as GameObject;

        switch (probLletra)
        {
            case 3:
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[letraRandomAdivinar];
                p.gameObject.tag = spritesNumerosLetras[letraRandomAdivinar].name;
                break;
            default:
                letraRandom = Random.Range(0, 27);
                p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[letraRandom];
                p.gameObject.tag = spritesNumerosLetras[letraRandom].name;
                break;
        }
    
    }
    public override void valorAdivinar()
    {
        GameObject.Find("valorAdivinar").GetComponent<Image>().sprite= spritesNumerosLetras[letraRandomAdivinar];
        tagAdivinar = spritesNumerosLetras[letraRandomAdivinar].name;
    }
}
