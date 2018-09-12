using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;
using UnityEngine.WSA;

namespace Projectiles
{

    [CreateAssetMenu(fileName = "New Bullet", menuName = "Bullets" )]	
    public class BulletTypes : ScriptableObject
    {
        public int Speed;

        public enum Direction
        {
            Left, 
            MidLeft, 
            Down, 
            MidRight, 
            Right
            
        }
        
        public Image Sprite;
        public Direction DirectionMenu;
    }
}

