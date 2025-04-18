using System;
using MANAGER.INTERFACE;
using UnityEngine;

namespace MANAGER
{
    public class InputManager : MonoBehaviour ,IInputManager
    {
        public Action KeyAction;


        private void Update()
        {
            OnUpdate();
        }


        public void OnUpdate()
        {
            KeyAction?.Invoke();
        }

        public void RegisterInput(Action action)
        {
            KeyAction += action;
        }

        public void UnRegisterInput(Action action)
        {
            KeyAction -= action;
        }
    }
}