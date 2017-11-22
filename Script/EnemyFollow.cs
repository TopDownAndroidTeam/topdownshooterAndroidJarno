using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public float speed;

	void Update() {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, step);
	}

}
