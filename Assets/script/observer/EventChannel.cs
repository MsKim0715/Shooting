using System;
using UnityEngine;
using UnityEngine.Events;

namespace observer
{
    /* */
    public abstract class EventChannel<T> : ScriptableObject
    {
        public Action<T> OnEventRaised;

        public void Raised(T value)
        {
            OnEventRaised?.Invoke(value);
        }
    }
}