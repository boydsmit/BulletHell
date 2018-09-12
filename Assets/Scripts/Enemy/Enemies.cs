using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using Image = UnityEngine.UI.Image;

namespace Enemy
{
	[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemies" )]	
	public class Enemies : ScriptableObject
	{
		public int Health;
		public int Weapons;

		public Sprite SpriteImage;

		public bool Moving;
	}
}