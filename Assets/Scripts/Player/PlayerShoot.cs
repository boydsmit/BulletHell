using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
	public class PlayerShoot : MonoBehaviour
	{
		
		[SerializeField]
		private GameObject _bullet;
		
		public void Shoot()
		{
			Instantiate(_bullet);
		}
	}
}