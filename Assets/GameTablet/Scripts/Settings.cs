using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour {


    public GameObject panel;
    public GameObject buttonRight;
    public GameObject buttonLeft;
    public static bool gamePause = false;
    bool state;

    public  void panelShowHide()
    {
        //pausa el joc, i mostra el menu de pausa
        gamePause = !gamePause;
        state = !state;
        panel.gameObject.SetActive(state);
        
    }

    public void salirMenu()
    {
        //acaba el nivell i torna al menu principal
        ScoreScript.scoreValue = 0;
        SceneManager.LoadScene(0);
    }
    public void salirJuego()
    {
        //tanca el joc
        Application.Quit();
    }
    public void replayGame()
    {
        //reinicia el nivell
        ScoreScript.scoreValue = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
