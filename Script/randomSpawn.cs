using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawn : MonoBehaviour {

	public GameObject prefab;

	private int timer = 5;
	private int quick = 0;
	// Update is called once per frame
	void Update () {

		timer = timer - 1;

		if (timer == 0)
		{
			timer = 150 - quick;
			quick = quick + 5;
		Vector3 position = new Vector3 (Random.Range (-50.0f, 50.0f), 1, Random.Range (-50.0f, 50.0f));
		Instantiate (prefab, position, Quaternion.identity);
		}

		if (quick >= 150) {
			quick = 145;
		}
	}
}
