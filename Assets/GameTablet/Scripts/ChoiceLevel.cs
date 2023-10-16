using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceLevel : MonoBehaviour {

    public void loadPlaneta()
    {
        //carrega la escena dels planetes
        SceneManager.LoadScene(2);
    }
    public void loadNivel(string nivel)
    {
        //carrega la escena del nivell, carregant el script corresponent del nivell
        PlayerPrefs.SetString("Nivel", nivel);
        SceneManager.LoadScene(1);
    }
}
