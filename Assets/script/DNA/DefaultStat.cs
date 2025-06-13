
using UnityEngine;

namespace DNA
{
    [CreateAssetMenu(fileName = "DefaultStat", menuName = "data/defaultStat")]
    public class DefaultStat : ScriptableObject
    {
        public string objectId;
        public int hp;
        public int attack;
        public int moveSpeed;
        public int attackSpeed;
    }
    
 
}