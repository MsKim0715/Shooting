using System;

namespace MANAGER.INTERFACE
{
    public interface IInputManager
    {
        void OnUpdate();
        void RegisterInput(Action action);
        void UnRegisterInput(Action action);
    }
}