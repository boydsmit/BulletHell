using UnityEngine;

namespace Enemy
{
    [CreateAssetMenu(fileName = "New Enemy", menuName = "Enemies")]
    public class Enemies : ScriptableObject
    {
        public int Health;
        public int Weapons;

        public Sprite SpriteImage;

        public bool Moving;
    }
}