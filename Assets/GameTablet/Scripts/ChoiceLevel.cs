using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceLevel : MonoBehaviour {

    public void loadPlaneta(string planeta)
    {
        //carrega la escena dels planetes
       PlayerPrefs.SetString("Planeta", planeta);
            
        switch (PlayerPrefs.GetString("Planeta"))
        {
            case "Planeta1":
                SceneManager.LoadScene(1);
                break;

            case "Planeta2":
                SceneManager.LoadScene(2);
                break;

            case "Planeta3":
                SceneManager.LoadScene(3);
                break;

            case "Planeta4":
                SceneManager.LoadScene(4);
                break;

            case "Selector":
                SceneManager.LoadScene(0);
                break;
            case "Creditos":
                SceneManager.LoadScene(6);
                break;
        }
    }   
        
    public void loadNivel(string nivel)
    {
        //carrega la escena del nivell, carregant el script corresponent del nivell
        PlayerPrefs.SetString("Nivel", nivel);
        SceneManager.LoadScene(5);
    }
}
