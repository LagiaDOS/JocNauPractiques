﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour {

    public float Tiemporestante;

    public Text credits;
    public float _x, _y;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.up * 1.1f * Time.deltaTime);
        Tiemporestante -= Time.deltaTime;


        if (Tiemporestante <= 0.0f)
        {
            SceneManager.LoadScene(0);
        }

    }
}
