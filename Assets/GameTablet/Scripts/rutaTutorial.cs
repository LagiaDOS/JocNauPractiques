using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rutaTutorial : MonoBehaviour {

    public float _x, _y;

    void Start () {
		
	}
	
//despareix despres de 35 segons
	void Update () {
        transform.Translate(Vector3.down * 1.1f * Time.deltaTime);
    }

    //fer que on collider sigui constant i posi punts tot el rato
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {  
        ScoreScript.scoreValue += 10;
        }
    }



}
