using UnityEngine;

namespace locomotion
{
    public class Movement : MonoBehaviour
    {
        
        public Vector2 Velocity { get; private set; }
        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }

        public void LateUpdate()
        {
            var position = _transform.position;
            var newPosition = new Vector2(position.x, position.y);

            if (Velocity.magnitude > 0.01f)
            {
                _transform.position = newPosition + Velocity * Time.deltaTime;
            }
        }

        public void SetVelocity(Vector2 newVelocity)
        {
            Velocity = newVelocity;
        }
    }
}