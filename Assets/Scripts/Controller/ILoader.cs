using System.Collections.Generic;

namespace Controller
{
    public interface ILoader<TKey,TValue>
    {
        Dictionary<TKey, TValue> MakeDic();
        TValue GetByKey(TKey key);
    }
}