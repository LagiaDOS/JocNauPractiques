using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSprite : MonoBehaviour {

    public Sprite spriteRight, spriteLeft, spriteNeutral;

    private void Update () {

        //activa si esta la lletra D o flecha dreta
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            //move right
            
            GetComponent<SpriteRenderer>().sprite = spriteRight;
        }
        //activa si esta la lletra A o flecha esquerra
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //move left
            GetComponent<SpriteRenderer>().sprite = spriteLeft;
        }
        //activa si no estas amb ninguna lletra
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            //no move
            GetComponent<SpriteRenderer>().sprite = spriteNeutral;
        }
   
    }
}
