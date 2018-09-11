using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Projectiles
{
	public class PlayerBullet : MonoBehaviour
	{
		[SerializeField]
		private float _bulletSpeed;
		
		private Rigidbody2D _rb;

		private void Start()
		{
			_rb = GetComponent<Rigidbody2D>();
		}

		void Update()
		{
			_rb.velocity = transform.position * _bulletSpeed ;
		}
	}
}