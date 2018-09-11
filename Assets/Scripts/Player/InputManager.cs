using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{

	public class InputManager : MonoBehaviour
	{

		private PlayerMove _playerMove;

		// Update is called once per frame

		private void Start()
		{
			_playerMove = GetComponent<PlayerMove>();
		}

		void Update()
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
	}
}