using System;
using UnityEngine;

namespace MANAGER
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