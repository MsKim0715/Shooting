using UnityEngine;

namespace Manager
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