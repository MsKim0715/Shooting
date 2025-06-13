using locomotion;
using UnityEngine;

namespace command
{
    public class MoveCommandInput : ICommandInput
    {
        private readonly Movement _movement;
        private readonly Vector2 _direction;
        private readonly float _speed;

        public MoveCommandInput(Movement movement, Vector2 direction, float speed)
        {
            _movement = movement;
            _direction = direction;
            _speed = speed;
        }

        public void Execute()
        {
            Debug.Log("Command");
            _movement.SetVelocity(_direction * _speed);
        }
    }
}