namespace CONTROLLER
{
    public interface IJsonLoader
    {
        TLoader LoadJson<TLoader, TKey, TValue>(string path) where TLoader : ILoader<TKey, TValue>;
    }
}