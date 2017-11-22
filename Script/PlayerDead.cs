using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour {

	void OnTriggerEnter(Collider other) {

		if (other.tag == "enemy")
		{
			SceneManager.LoadScene ("GameoverScreen");
		}
	}

}
