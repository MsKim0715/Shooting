using System;
using System.Collections.Generic;
using CONTROLLER;

namespace DATA.STAT
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
        public List<PlayerStat> stats = new();
        private Dictionary<string, PlayerStat> _dict;
        public Dictionary<string, PlayerStat> MakeDic()
        {
            /* 딕셔너리가 null일 떄 값 넣기 */
            if (_dict == null)
            {
                _dict = new();

                foreach (var stat in stats)
                {
                    _dict.Add(stat.playerID, stat);
                }
            }
            return _dict;
        }
        
        /* key 값으로 PlayerStat 얻어오는 메서드 */
        public PlayerStat GetByKey( string key)
        {
            var dic = MakeDic();
            dic.TryGetValue(key, out var stat);
            return stat;
        }
    }
}