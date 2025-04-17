using System;
using UnityEngine;


namespace Manager
{
    public class InputManager : MonoBehaviour
    {
        public Action KeyAction = null;

        
        public void OnUpdate()
        {
            KeyAction?.Invoke();
        }
    }
}