using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerTimer : MonoBehaviour {

	int timeLeft;
	private Text timerText;

	private void Awake(){
		timerText = GameObject.Find("GuiText").GetComponent<Text> ();
	}

	void Start(){
		timeLeft = 4300;
	}
	
	// Update is called once per frame
	void Update() {

		timeLeft = timeLeft - 1;

		if (timeLeft <= 0){
			SceneManager.LoadScene ("WinScreen");
		}
		timerText.text = "Time Left: " + timeLeft;
	}
}
