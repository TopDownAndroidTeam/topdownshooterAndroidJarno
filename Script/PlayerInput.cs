using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles all input (mouse / keyboard)
/// provided by the user.
/// </summary>

public class PlayerInput : MonoBehaviour
{

    private PlayerMovement _playerMovement;
	private PlayerShoot	_playershoot;

	private float timeBetweenShots = 0.1f;
	private float timestamp;

    void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
		_playershoot = GetComponent<PlayerShoot>();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            _playerMovement.LookAt(hit.point);
            Debug.DrawRay(ray.origin, hit.point);
        }

		if (Time.time >= timestamp && (Input.GetMouseButton (0)) )
		{
			_playershoot.Shoot();
			timestamp = Time.time + timeBetweenShots;
		}

    }
}
