
using DNA;
using actor;
using UnityEngine;
using locomotion.state;
namespace locomotion
{
    public  abstract class MoveBase : MonoBehaviour
    {

        protected Stat SpeedStat;
        
        public Movement Movement { get; private set; }
        public float MoveSpeed { get; private set; }

        protected virtual void Awake()
        {
            Movement = GetComponent<Movement>();
            SpeedStat = GetComponent<Stats>().GetStat(StatType.MoveSpeed);
            MoveSpeed = SpeedStat.value * 0.7f;
        }
    }
}