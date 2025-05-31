    namespace singleTon
    {
        public class SingleTon<T> where T : new()
        {
            private static class SingleTonHolder
            {
                internal static readonly T _instance = new();
            }

            public static T Instance => SingleTonHolder._instance;

            
        }
    }