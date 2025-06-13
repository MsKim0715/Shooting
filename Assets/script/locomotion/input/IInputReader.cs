using UnityEngine;

namespace locomotion.input
{
    public interface IInputReader
    {
        public Vector2 GetMoveDirection();
    }
}