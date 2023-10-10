using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSprite : MonoBehaviour {

    public Sprite spriteRight, spriteLeft, spriteNeutral;

    private void Update () {

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            //move right
            
            GetComponent<SpriteRenderer>().sprite = spriteRight;
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //move left
            GetComponent<SpriteRenderer>().sprite = spriteLeft;
        }
        /*else if ()
        {
            //no move
            GetComponent<SpriteRenderer>().sprite = spriteNeutral;
        }*/

    }
}
