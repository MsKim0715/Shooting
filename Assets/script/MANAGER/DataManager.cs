using CONTROLLER;
using MANAGER.INTERFACE;
using UnityEngine;

namespace MANAGER
{
    public class DataManager : MonoBehaviour , IDataManager
    {
        private IDataLoader _loader;
        
        /* IJsonLoader 의존성 주입 */
        public void Init(IDataLoader dataLoder)
        {
            _loader = dataLoder;
        }
        
        
        /* JsonData를 로드하는 메서드 */
        public  TLoader LoadJson<TLoader, TKey, TValue>(string path) where TLoader : ILoader<TKey, TValue>
        {
            return _loader.LoadJson<TLoader,TKey,TValue>(path);
        }
        
    }
} 