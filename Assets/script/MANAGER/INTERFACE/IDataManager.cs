using CONTROLLER;

namespace MANAGER.INTERFACE
{
    public interface IDataManager
    {
        void Init(IDataLoader dataLoder );
        TLoader LoadJson<TLoader, TKey, TValue>(string path) where TLoader : ILoader<TKey, TValue>;
    }
}