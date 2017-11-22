using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	[SerializeField]
	private float _speed;

	private Rigidbody _rigidbody;

	public float timer;

	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		Vector3 velocity = transform.forward * _speed * Time.fixedDeltaTime;
		_rigidbody.MovePosition (_rigidbody.position + velocity);

		timer += 1.0F * Time.deltaTime;

		if (timer >= 1)
		{
			GameObject.Destroy(gameObject);
		}
	}

	void OnTriggerEnter(Collider other) {

		if (other.tag == "wall")
		{
			Destroy (gameObject);
		}
	}

}