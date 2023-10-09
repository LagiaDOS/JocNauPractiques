using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel1 : Niveles
{

    void Update()
    {
        
        if (gameOver==false)
        {
            if (!Settings.gamePause)
            {
                spwanLetrasNumros -= Time.deltaTime;

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
        p.GetComponent<SpriteRenderer>().sprite = spritesNumerosLetras[letraRandom];
        p.gameObject.tag = spritesNumerosLetras[letraRandom].name;
    }
    public override void valorAdivinar()
    {
        GameObject.Find("valorAdivinar").GetComponent<Image>().sprite= spritesNumerosLetras[letraRandom];
        tagAdivinar = spritesNumerosLetras[letraRandom].name;
    }
}
