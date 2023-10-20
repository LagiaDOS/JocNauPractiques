using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{

    public GameObject character;
    public float speed;
    public float meTime = 15.0f;
    public static bool speedup = false;
    bool speeddown = false;

    // Use this for initialization
    void Start() {
        speed = Niveles.speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Niveles.gameOver && !Settings.gamePause)
        {
            //fa que el objecte baixi a X velocitat
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            meTime -= Time.deltaTime;
            //Si el objeto supera el valor de la y, lo destruimos
            if (meTime <= 0)
            {
                if (speedup == true) {
                    Debug.Log("speed up destroy", gameObject);
                }
                if (speeddown == true) {
                    Niveles.speed = Niveles.speed + 1.0f;
                }
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Si los objetos que bajan, han colisionado con el jugador accedemos al if
        if (other.tag == "Player")
        {
            if (this.tag == "Speed") {
            // playerMovimiento.speed = playerMovimiento.speed + 10.0f;
            speedup = true;
            Debug.Log("speed up", gameObject);
                Debug.Log(speedup, gameObject);

            }

            if (this.tag == "Slow") {
                Niveles.speed = Niveles.speed-1.0f;
                speeddown = true;
            }

            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;


        }
    }



}



