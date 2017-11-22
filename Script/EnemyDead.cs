using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour {

	int killcount;

	void Start(){
		killcount = 0;
	}

	void OnTriggerEnter(Collider other) {

		if (other.tag == "bullet")
		{
			Destroy (gameObject);
			killcount = killcount + 1;
		}
	}

	void Update(){
		//Debug.Log (killcount);

	}
}