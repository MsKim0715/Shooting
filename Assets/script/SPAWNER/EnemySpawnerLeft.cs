using System.Collections.Generic;
using DATA.SpawnData;
using DATA.UTIL;
using MANAGER;
using SPAWNER.INTERFACE;
using UnityEngine;

namespace SPAWNER
{
    public class EnemySpawnerLeft : MonoBehaviour , ISpawner
    {

        private ResourcePath _spawnJsonPath; 
        private Dictionary<int,EnemySpawnerLeftData> _data = new();
        private string _path;
        
        private void Start()
        {
            _spawnJsonPath = Managers.ResourceManager.GetResourcePath();
            _path = _spawnJsonPath.enemySpawnerLeftJsonPath;
            _data = Managers.DataManager.LoadJson<EnemySpawnerLeftDataDict, int, EnemySpawnerLeftData>(_path).MakeDic();
            Spawn();
        }
        
        public void Spawn()
        {
            // int spawnKey = _data[0].stage;
            // Managers.SpawnManager.GetTest(spawnKey);
            foreach (var data in _data)
            {
                Debug.Log(data.Key +" " + data.Value);
            }
            
        }
    }
}