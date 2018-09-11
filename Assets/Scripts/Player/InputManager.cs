using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{

	public class InputManager : MonoBehaviour
	{
		private PlayerShoot _playerShoot;
		private PlayerMove _playerMove;

		private void Start()
		{
			_playerMove = GetComponent<PlayerMove>();
			_playerShoot = GetComponent<PlayerShoot>();
		}

		void Update()
		{
			CheckSlowMode();
			CheckShoot();
		}

		private void CheckSlowMode()
		{
			if (Input.GetKey(KeyCode.LeftShift))
			{
				_playerMove.Slowmode();

			}
			else
			{
				_playerMove.NormalMode();
			}
		}

		private void CheckShoot()
		{
			if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Mouse0))
			{
				_playerShoot.Shoot();
			}
		}
	}
}