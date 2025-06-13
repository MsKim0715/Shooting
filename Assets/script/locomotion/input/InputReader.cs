using UnityEngine;
namespace locomotion.input
{
    public class InputReader : MonoBehaviour, IInputReader
    {
        

        public Vector2 GetMoveDirection()
        {
            var dir = Vector2.zero;
            if (Input.GetKey(KeyCode.UpArrow)) dir += Vector2.up;
            if (Input.GetKey(KeyCode.DownArrow)) dir += Vector2.down;
            if (Input.GetKey(KeyCode.RightArrow)) dir += Vector2.right;
            if (Input.GetKey(KeyCode.LeftArrow)) dir += Vector2.left;
            return dir.normalized;
        }
        
    }
}