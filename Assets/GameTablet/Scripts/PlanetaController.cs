using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetaController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.FindGameObjectWithTag("Planeta").GetComponent<Image>().sprite = Resources.Load<Sprite>("Planetas/Planeta1");
        GameObject.FindGameObjectWithTag("Planeta").GetComponent<Image>().sprite = Resources.Load<Sprite>("Planetas/Planeta2");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
