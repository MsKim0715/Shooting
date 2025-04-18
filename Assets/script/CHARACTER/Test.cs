using MANAGER;
using UnityEngine;

namespace CHARACTER
{
    public class Test : MonoBehaviour
    {
        private Rigidbody2D rb;
        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            Managers.InputManager.UnRegisterInput(OnKeyboard);
            Managers.InputManager.RegisterInput(OnKeyboard);
        }


        void OnKeyboard()
        {
            Vector2 moveDir = Vector2.zero;

            //이동 로직
            if (Input.GetKey(KeyCode.UpArrow)){ moveDir += Vector2.up;}
            if (Input.GetKey(KeyCode.DownArrow)){ moveDir += Vector2.down;}
            if (Input.GetKey(KeyCode.LeftArrow)){ moveDir += Vector2.left;}
            if (Input.GetKey(KeyCode.RightArrow)){ moveDir += Vector2.right;}

            //대각선 이동
            if (moveDir != Vector2.zero){ rb.linearVelocity = moveDir.normalized * 3;}
            else {rb.linearVelocity = Vector2.zero;}
            
        }
    }
}