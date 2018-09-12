using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Enemy
{
	[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemies" )]	
	public class Enemies : ScriptableObject
	{
		public int Health;
		public int Weapons;

		public Sprite SpriteImage;
	}
}