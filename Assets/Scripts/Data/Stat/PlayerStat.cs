using System;
using System.Collections.Generic;
using Controller;

namespace Data.Stat
{
    [Serializable]
    public class PlayerStat<T>
    {
        public T PlayerID { get; set; }
        public float Hp { get; set; }
        public float Attack { get; set; }
        public float Speed { get; set; }
    }
    
    
    [Serializable]
    public class PlayerStatData<T> : ILoader<T, PlayerStat<T>>
    {
        public List<PlayerStat<T>> stats = new();
        private Dictionary<T, PlayerStat<T>> _dic;
        public Dictionary<T, PlayerStat<T>> MakeDic()
        {
            /* 딕셔너리가 null일 떄 값 넣기 */
            if (_dic == null)
            {
                _dic = new();

                foreach (var stat in stats)
                {
                    _dic.Add(stat.PlayerID, stat);
                }
            }
            return _dic;
        }

        /* key 값으로 PlayerStat 얻어오는 메서드 */
        public PlayerStat<T> GetByKey(T key)
        {
            var dic = MakeDic();
            dic.TryGetValue(key, out var stat);
            return stat;
        }
    }
}