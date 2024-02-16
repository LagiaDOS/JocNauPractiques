using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correcteIncorrecteFadeout : MonoBehaviour {


    private float temps = 0.5f;
	// Use this for initialization
	void Start () {

        GameObject canvasRend = GameObject.Find("Canvas2");
        this.transform.parent = canvasRend.transform;

        this.transform.localScale = new Vector3(1, 1, 0);
    }

    // Update is called once per frame
    void Update () {

        temps -= Time.deltaTime;
        if (temps <= 0.0f)
        {
            Destroy(this.gameObject);
        }



    }
}
