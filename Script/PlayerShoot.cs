using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	public Rigidbody Projectile;

	public void Shoot () {
		Rigidbody projectileClone = (Rigidbody)Instantiate (Projectile, transform.position, transform.rotation);
	}
}
