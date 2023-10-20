using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceLevel : MonoBehaviour {

    public void loadPlaneta(string planeta)
    {
        //carrega la escena dels planetes
        PlayerPrefs.SetString("Planeta", planeta);
        SceneManager.LoadScene(2);
    }
    public void loadNivel(string nivel)
    {
        //carrega la escena del nivell, carregant el script corresponent del nivell
        PlayerPrefs.SetString("Nivel", nivel);
        SceneManager.LoadScene(1);
    }
}
