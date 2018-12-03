using UnityEngine;
using UnityEngine.UI;

namespace Enemy
{
    public class CheckEnemy : MonoBehaviour
    {
        public Enemies EnemyType;

        private int _health;
        private int _weapons;

        public Image Sprite;

        void Start()
        {
            _health = EnemyType.Health;
            _weapons = EnemyType.Weapons;

            Sprite.sprite = EnemyType.SpriteImage;
        }
    }
}