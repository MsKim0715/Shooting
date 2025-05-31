using UnityEngine;

namespace manager
{
    public class TestManager : Manager
    {
        public override void OnAwake()
        {
            Debug.Log("Hello world!");
        }
    }
}