using UnityEngine;

namespace Player
{
    public class PlayerMove : MonoBehaviour
    {
        private Rigidbody2D _rb;

        [SerializeField] private float _initialMoveSpd;

        private float _moveSpeed;

        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _moveSpeed = _initialMoveSpd;
        }

        void Move(float x, float y)
        {
            _rb.velocity = new Vector2(x, y).normalized * _moveSpeed * Time.deltaTime;
        }

        void Update()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            Move(x, y);
        }

        public void Slowmode()
        {
            _moveSpeed = _initialMoveSpd / 2;
        }

        public void NormalMode()
        {
            _moveSpeed = _initialMoveSpd;
        }
    }
}