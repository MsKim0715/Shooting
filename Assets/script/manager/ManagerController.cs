using System;
using System.Collections.Generic;
using singleTon;

namespace manager
{
    public class ManagerController : SingleTon<ManagerController>
    {
        private Dictionary<string, List<Manager>> _managers = new();
        

        public void Register(string key, Manager manager)
        {
            if (!_managers.ContainsKey(key))
            {
                _managers[key] = new List<Manager>();
            }
            
            _managers[key].Add(manager);
        }

        public void UnResister(string key)
        {
            if (_managers.ContainsKey(key))
            {
                _managers.Remove(key);
            }
        }

        public List<Manager> GetManager(string key)
        {
            if (_managers.TryGetValue(key, out var managers))
            {
                return managers;
            }

            return new List<Manager>();
        }
        
        private void ExcuteManager(Action<Manager> action)
        {
            try
            {
                foreach (var managerList in _managers.Values)
                {
                    foreach (var value in managerList)
                    {
                        action(value);
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.Write($"[Error] {e.Message}\n{e.StackTrace}");
            }
           
        }

        public void AwakeAll() => ExcuteManager(manager =>  manager.OnAwake());
        public void StartAll() => ExcuteManager(manager =>  manager.OnStart());
        public void UpdateAll() => ExcuteManager(manager =>  manager.OnUpdate());
        public void FixedUpdateAll() =>ExcuteManager(manager => manager.OnFixedUpdate());
    }
}