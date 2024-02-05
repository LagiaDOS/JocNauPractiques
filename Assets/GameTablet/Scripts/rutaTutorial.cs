using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rutaTutorial : MonoBehaviour {

    public float _x, _y;
    public GameObject canvasRend;

    void Start () {
        canvasRend = GameObject.Find("Canvas2");
        this.transform.parent = canvasRend.transform;
        this.transform.localScale = new Vector3(25, 25, 0);
    }
	
//despareix despres de 35 segons
	void Update () {

        if (!Niveles.gameOver && !Settings.gamePause)
        {
            transform.Translate(Vector3.down * 1.1f * Time.deltaTime);

            if (transform.position.y < -20.0f)
            {
                Destroy(this.gameObject);
            }
        }

    }

    //fer que on collider sigui constant i posi punts tot el rato
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {  
        ScoreScript.scoreValue += 5;
        }
    }



}
