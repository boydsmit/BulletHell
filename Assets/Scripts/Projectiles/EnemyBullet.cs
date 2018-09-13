using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Projectiles
{

	public class EnemyBullet : MonoBehaviour
	{
		public BulletTypes BulletType;

		private float _speed;

		void Start()
		{
			_speed = BulletType.Speed / -1;
		}

		void Update()
		{
			CheckDirection();
		}

		private void CheckDirection()
		{
			switch (BulletType.DirectionMenu)
			{
					case BulletTypes.Direction.Left:
						MoveBullet(_speed, 0);
						break;
					
					case BulletTypes.Direction.MidLeft:
						MoveBullet(_speed , _speed);
						break;
					
					case BulletTypes.Direction.Down:
						MoveBullet(0, _speed);
						break;
					
					case BulletTypes.Direction.MidRight:
						MoveBullet(_speed / 2, _speed);
						break;
					
					case BulletTypes.Direction.Right:
						MoveBullet(_speed / 2, _speed);
						break;
			}
		}
		
		private void MoveBullet(float x, float y)

		{
			gameObject.transform.Translate(x * Time.deltaTime, y * Time.deltaTime, 0);
		}
	}

}