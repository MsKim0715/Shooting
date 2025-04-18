using System;
using System.Collections.Generic;
using CONTROLLER;
using Newtonsoft.Json;

namespace DATA.SpawnData
{
    [Serializable]
    public class EnemySpawnerLeftData
    {

        
        [JsonProperty("Stage")] public int stage;
        [JsonProperty("Enemy")]public string enemy;
    }

    [Serializable]
    public class EnemySpawnerLeftDataDict : ILoader<int, EnemySpawnerLeftData>
    {
        [JsonProperty("Spawn")]   public List<EnemySpawnerLeftData> datas = new();
        private Dictionary<int, EnemySpawnerLeftData> _dict;
        
        public Dictionary<int, EnemySpawnerLeftData> MakeDic()
        {
            if (_dict == null)
            {
                _dict = new();

                foreach (var data in datas)
                {
                    _dict.Add(data.stage, data);
                }
            }
            return _dict;
        }

        public EnemySpawnerLeftData GetByKey(int key)
        {
            var dic = MakeDic();
            _dict.TryGetValue(key, out var data);
            return data;
        }
    } 
}