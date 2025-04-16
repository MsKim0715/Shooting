using UnityEngine;

namespace SingleTon
{
    public class SingleTon<T> : MonoBehaviour where T : Component
    {
        private static T _instance;
        public static bool HasInstance => _instance != null;
        public static T TryGetInstance() => HasInstance ? _instance : null;
        public static T Current => _instance;


        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance =  FindAnyObjectByType<T>();
                    if (_instance == null)
                    {
                        GameObject obj = new GameObject
                        {
                            name = typeof(T).Name
                        };
                        _instance = obj.AddComponent<T>();
                    }
                }
                
                return _instance;
            }
        }


        protected virtual void Awake()
        {
            InitSingleTon();
            
        }

        private void InitSingleTon()
        {
            if (!Application.isPlaying)
            {
                return;
            }

            _instance = this as T;
        }
        
        

    }
}