namespace CONTROLLER
{
    public interface IDataLoader
    {
        TLoader LoadJson<TLoader, TKey, TValue>(string path) where TLoader : ILoader<TKey, TValue>;
    }
}