using UnityEngine;

namespace MANAGER
{
    public class SpawnManager : MonoBehaviour
    {
        private PoolManager _pooler = Managers.PoolManager;



      public  string GetTest(string key)
      {
          return _pooler.Test(key);
      }
        
        /*GameObject GetSpawnObj<T>(T id)
        {
            //TODO
            return null;
        }*/
    }
}