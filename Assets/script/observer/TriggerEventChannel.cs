using System;
using UnityEngine;

namespace observer
{
    public abstract class TriggerEventChannel : ScriptableObject
    {
        public Action OnEventRaised;
        

        public void Raised()
        {
            OnEventRaised?.Invoke();
        }
    }
}