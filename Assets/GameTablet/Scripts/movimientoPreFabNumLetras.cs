using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPreFabNumLetras : MonoBehaviour {
    public AudioClip _audioSource;
    public float speed;
    // Use this for initialization
    void Start () {
        speed = Niveles.speed;
	}
	
	// Update is called once per frame
	void Update () {
        if (!Niveles.gameOver && !Settings.gamePause)
        {
            //fa queel objecte baixi a X velocitat
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            //Si el objeto supera el valor de la y, lo destruimos
            if (transform.position.y < -6.0f)
            {
               Destroy(this.gameObject);
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Si los objetos que bajan, han colisionado con el jugador accedemos al if
        if (other.tag == "Player")
        {
            if (this.tag == Niveles.tagAdivinar)
            {
                ScoreScript.scoreValue += 100;
            }
            //Si no restamos 20 puntos
            else
            {
                ScoreScript.scoreValue -= 20;
            }
            AudioSource.PlayClipAtPoint(_audioSource, transform.position);
            //Destruimos el objeto que ha colisionado con el jugador
            Destroy(this.gameObject);
        }
    }

}
