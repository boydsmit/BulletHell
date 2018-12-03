using UnityEngine;
using UnityEngine.UI;

namespace Projectiles
{
    [CreateAssetMenu(fileName = "New Bullet", menuName = "Bullets")]
    public class BulletTypes : ScriptableObject
    {
        public float Speed;

        public enum Direction
        {
            Up,
            MidLeftU,
            Left,
            MidLeftD,
            Down,
            MidRightD,
            Right,
            MidRightU
        }

        public Image Sprite;
        public Direction DirectionMenu;
    }
}