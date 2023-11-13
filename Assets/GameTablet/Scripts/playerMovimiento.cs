using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovimiento : MonoBehaviour
{

    public GameObject character;
    private Rigidbody2D characterBody;
    private float ScreenWidth;
    float playerSpeed;

    // Use this for initialization
    void Start()
    {
        ScreenWidth = Screen.width;
        characterBody = character.GetComponent<Rigidbody2D>();
        playerSpeed = powerUp.speedup ? 1.0f : 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Niveles.gameOver && !Settings.gamePause)
        {
            RunCharacter(Input.GetAxis("Horizontal") * playerSpeed);       
        }
    }

/*    void FixedUpdate()
    {
#if UNITY_EDITOR
        float playerSpeed = powerUp.speedup ? 1.0f : 0.3f;
        RunCharacter(Input.GetAxis("Horizontal") * playerSpeed);
#endif
    }*/

    private void RunCharacter(float horizontalInput)
    {
        Vector3 posaux = characterBody.transform.position;
        Vector3 pos = posaux;

        pos.x += 10.0f * Time.deltaTime * horizontalInput;

        Vector3 aux = Camera.main.WorldToViewportPoint(pos);

        if (aux.x <= 0.1f || aux.x >= 0.9f)
        {
            characterBody.transform.position = posaux;
        }
        else
        {
            characterBody.transform.position = pos;
        }


    }
}
