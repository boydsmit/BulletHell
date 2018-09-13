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
				case BulletTypes.Direction.Up:
					MoveBullet(0, _speed / 2);
					break;
					
				case BulletTypes.Direction.MidLeftU:
					MoveBullet(_speed, _speed / 2);
					break;
				
					case BulletTypes.Direction.Left:
						MoveBullet(_speed, 0);
						break;
					
					case BulletTypes.Direction.MidLeftD:
						MoveBullet(_speed, _speed);
						break;
					
					case BulletTypes.Direction.Down:
						MoveBullet(0, _speed);
						break;
					
					case BulletTypes.Direction.MidRightD:
						MoveBullet(_speed / 2, _speed);
						break;
					
					case BulletTypes.Direction.Right:
						MoveBullet(_speed / 2, _speed);
						break;
					
					case BulletTypes.Direction.MidRightU:
						MoveBullet(_speed / 2, _speed / 2);
						break;
			}
		}
		
		private void MoveBullet(float x, float y)

		{
			gameObject.transform.Translate(x * Time.deltaTime, y * Time.deltaTime, 0);
		}
	}

}