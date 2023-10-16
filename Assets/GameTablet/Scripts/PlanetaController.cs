﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetaController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //cambia el sprite dels planetes al corresponent.
        //aixo esta sense acabar, a la base de dades te que llegir quins planetes tens desbloquejats i quins no.
        GameObject.FindGameObjectWithTag("Planeta").GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Planetas/Planeta1");
        GameObject.FindGameObjectWithTag("Planeta").GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Planetas/Planeta2");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
