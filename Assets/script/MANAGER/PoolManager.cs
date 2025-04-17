using UnityEngine;

namespace MANAGER
{
    public class PoolManager : MonoBehaviour
    {

        public string Test(string key)
        {
            string test = "test : " + key;
            
            return test;
        }
    }
}