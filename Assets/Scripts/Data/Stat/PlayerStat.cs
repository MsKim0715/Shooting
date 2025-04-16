using System;
using System.Collections.Generic;
using Controller;

namespace Data.Stat
{
    [Serializable]
    public class PlayerStat
    {
        public string playerID;
        public float hp;
        public float attack;
        public float speed;
    }
    
    
    [Serializable]
    public class PlayerStatData : ILoader<string, PlayerStat>
    {
        public List<PlayerStat> stats = new List<PlayerStat>();
        
        public Dictionary<string, PlayerStat> MakeDic()
        {
            Dictionary<string, PlayerStat> dic = new();

            foreach (var stat in stats)
            {
                dic.Add(stat.playerID, stat);
            }
            return dic;
        }
    }
}