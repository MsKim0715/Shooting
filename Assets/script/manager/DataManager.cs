
using System.Collections.Generic;
using System.Linq;
using DNA;
using singleTon;
using UnityEngine;

namespace manager
{
    [DefaultExecutionOrder(-10)]
    public class DataManager : SingleTon<DataManager>
    {
        [SerializeField] private List<DefaultStat> defaultStats;
        private Dictionary<string, DefaultStat> _stats;



        public override void Awake()
        {
            base.Awake();
            
            _stats = defaultStats.ToDictionary(x => x.objectId);

        }

        public DefaultStat GetStat(string key) {return _stats.GetValueOrDefault(key);}
       
    }
    
}