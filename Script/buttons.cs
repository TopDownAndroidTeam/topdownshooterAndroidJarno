using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour {

    public void StartButton(string StartLevel)
    {
        SceneManager.LoadScene("Top Down Shooter");
    }

    public void QuitButton(string QuitLevel){
		Application.Quit ();
	}

	public void HomeButton(string HomeButton){
        SceneManager.LoadScene ("StartScreen");
	}
}
