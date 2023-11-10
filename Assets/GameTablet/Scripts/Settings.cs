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

    public void nextLevel() {

        switch (PlayerPrefs.GetString("Nivel"))
        {
            case "Nivel1":
                PlayerPrefs.SetString("Nivel", "Nivel2");
                SceneManager.LoadScene(1);
                break;
            case "Nivel2":
                PlayerPrefs.SetString("Nivel", "Nivel3");
                SceneManager.LoadScene(1);
                break;
            case "Nivel3":
                PlayerPrefs.SetString("Nivel", "Nivel4");
                SceneManager.LoadScene(1);
                break;
            case "Nivel4":
                PlayerPrefs.SetString("Nivel", "Nivel5");
                SceneManager.LoadScene(1);
                break;
            case "Nivel5":
                PlayerPrefs.SetString("Nivel", "Nivel6");
                SceneManager.LoadScene(1);
                break;
            case "Nivel6":
                PlayerPrefs.SetString("Nivel", "Nivel7");
                SceneManager.LoadScene(1);
                break;
            case "Nivel7":
                PlayerPrefs.SetString("Nivel", "Nivel8");
                SceneManager.LoadScene(1);
                break;
            case "Nivel8":
                PlayerPrefs.SetString("Nivel", "Nivel9");
                SceneManager.LoadScene(1);
                break;
            case "Nivel10":
                PlayerPrefs.SetString("Nivel", "Nivel10");
                SceneManager.LoadScene(1);
                break;
            case "Nivel11":
                PlayerPrefs.SetString("Nivel", "Nivel12");
                SceneManager.LoadScene(1);
                break;
            case "Nivel12":
                //carregar escena de credits
                
                break;

        }


    }

}
