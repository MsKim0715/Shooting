using DATA.UTIL;
using MANAGER.INTERFACE;
using UnityEngine;

namespace MANAGER
{
    public class ResourceManager : MonoBehaviour, IResourceManager
    {
        [SerializeField] private ResourcePath resourcePath;
        
        
        public ResourcePath GetResourcePath()
        {
            if (resourcePath != null)
            {
                return resourcePath;
            }

            return null;
        }
    }
}