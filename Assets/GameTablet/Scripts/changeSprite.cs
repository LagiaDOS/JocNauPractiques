using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSprite : MonoBehaviour {

    public Sprite spriteRight, spriteLeft, spriteNeutral;

    private void Update()
    {
            //move right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
                // inputs for right and left
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<SpriteRenderer>().sprite = spriteNeutral;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = spriteRight;
            }
        }
            //move left
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // inputs for left and right
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<SpriteRenderer>().sprite = spriteNeutral;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = spriteLeft;
            }
        }
            // no input
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
             GetComponent<SpriteRenderer>().sprite = spriteNeutral;
        }
     
    }
}
