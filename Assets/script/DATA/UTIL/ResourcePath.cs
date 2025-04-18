using UnityEngine;

namespace DATA.UTIL
{
    [CreateAssetMenu(fileName = "JsonPathConfig", menuName = "Config/JsonPathConfig")]
    public class ResourcePath : ScriptableObject
    {

        [Header("PlayerData Json 경로")] 
        public string playerJsonPath;
        
        [Header("Enemy Json 경로")]
        public string enemyJsonPath;
        
        [Header("Spawner Json 경로")] 
        public string enemySpawnerLeftJsonPath;
        public string enemySpawnerMiddleLeftJsonPath;
        public string enemySpawnerMiddleRightJsonPath;
        public string enemySpawnerRightJsonPath;
        
    }    
}

