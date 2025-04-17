using System.Collections.Generic;

namespace CONTROLLER
{
    public interface ILoader<TKey,TValue>
    {
        Dictionary<TKey, TValue> MakeDic();
        TValue GetByKey(TKey key);
    }
}