using MANAGER.INTERFACE;
using UnityEngine;

namespace MANAGER
{
    public  class PoolManager : MonoBehaviour, IPoolManager
    {
        
        public string Test(int key)
        {
            string test = "test : " + key;
            
            return test;
        }
    }
}