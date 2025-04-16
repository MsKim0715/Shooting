using Controller;

namespace Manager
{
    public class DataManager
    {
        private readonly IJsonLoader _loader;
        
        /* IJsonLoader 의존성 주입 */
        public DataManager(IJsonLoader jsonLoader)
        {
            _loader = jsonLoader;
        }
        
        
        /* JsonData를 로드하는 메서드 */
        public  TLoader LoadJson<TLoader, TKey, TValue>(string path) where TLoader : ILoader<TKey, TValue>
        {
            return _loader.LoadJson<TLoader,TKey,TValue>(path);
        }
        
    }
} 