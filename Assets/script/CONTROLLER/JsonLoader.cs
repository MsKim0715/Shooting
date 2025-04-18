using System;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;


namespace CONTROLLER
{
    public class JsonLoader : IDataLoader

    {
        public TLoader LoadJson<TLoader, TKey, TValue>(string path) where TLoader : ILoader<TKey, TValue>
        {
            try
            {
                string fullPath = Path.Combine(Application.streamingAssetsPath, path);

                /* file이 경로에 없을 때 null 리턴 */
                if (!File.Exists(fullPath))
                {
                    return default;
                }

                string json = File.ReadAllText(fullPath);
                var result = JsonConvert.DeserializeObject<TLoader>(json);
                return result;
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }

            return default;
        }
    }
}