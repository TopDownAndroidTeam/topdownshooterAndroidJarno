using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour {

	[SerializeField]
	private float speed;


	void Start()
	{
		speed = 10;
	}


	void Update() {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

        float px = Input.acceleration.x;
        float pz = Input.acceleration.y;
	
		Vector3 direction = new Vector3 (x, 0f, z);
        Vector3 pDirection = new Vector3(px, 0f, pz);
		transform.Translate (direction * speed * 1.5f * Time.deltaTime, Space.World);
        transform.Translate (pDirection * speed * 1.5f * Time.deltaTime, Space.World);
	}
}
