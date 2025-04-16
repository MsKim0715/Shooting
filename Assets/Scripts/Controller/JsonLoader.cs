using System;
using UnityEngine;

namespace Controller
{
    public class JsonLoader : IJsonLoader

    {
        public TLoader LoadJson<TLoader, TKey, TValue>(string path) where TLoader : ILoader<TKey, TValue>
        {
            try
            {
                var textAsset = Resources.Load<TextAsset>(path);

                /* path 경로에 Json이 존재하지 않을 때 null 리턴 */
                if (textAsset == null)
                {
                    return default;
                }

                var result = JsonUtility.FromJson<TLoader>(textAsset.text);
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