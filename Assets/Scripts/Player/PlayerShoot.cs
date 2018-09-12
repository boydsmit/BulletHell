using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
	public class PlayerShoot : MonoBehaviour
	{
		private bool _shootTimer = true;
		
		[SerializeField]
		private  float _shootSpeed;
		[SerializeField]
		private GameObject _bullet;
		
		public void Shoot()
		{
			if (_shootTimer)
			{
				StartCoroutine(Timer());
				GameObject shotBullet = Instantiate(_bullet, gameObject.transform);
				Destroy(shotBullet, 1.0f);
			}
		}

		private IEnumerator Timer()
		{
			_shootTimer = false;
			yield return  new WaitForSeconds(_shootSpeed);
			_shootTimer = true;
		}
	}
}