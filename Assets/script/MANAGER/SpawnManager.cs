using MANAGER.INTERFACE;
using UnityEngine;

namespace MANAGER
{
    public class SpawnManager : MonoBehaviour,ISpawnManager
    {
        private IPoolManager _poolManager;
        
        private void Awake()
        {
            _poolManager = GetComponent<PoolManager>();
        }


        public  string GetTest(int key)
        {
            return _poolManager.Test(key);
        }
        
        /*GameObject GetSpawnObj<T>(T id)
        {
            return null;
        }*/
    }
}