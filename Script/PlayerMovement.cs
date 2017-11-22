using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	//Follow the mouse
    public void LookAt(Vector3 point)
	{
        transform.LookAt(point);
		transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y);
    }

	void FixedUpdate()
	{
		if (transform.position.y < -30)
		{
			transform.position = new Vector3(0, 10, 0);
		}
	}
}