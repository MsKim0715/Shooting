using System.Collections.Generic;
using System.Linq;
using DNA;
using manager;
using UnityEngine;

namespace actor
{
    [DefaultExecutionOrder(-9)]
    public class Stats : MonoBehaviour
    {
        [SerializeField] private string key;
        [SerializeField] private DefaultStat stat;

        [field: SerializeField] public Stat Health { get; private set; }
        [field: SerializeField] public Stat Attack { get; private set; }
        [field: SerializeField] public Stat MoveSpeed { get; private set; }
        [field: SerializeField] public Stat AttackSpeed { get; private set; }

        private Dictionary<StatType, Stat> _statDic;
        private readonly List<Stat> _stats = new();
        public List<Stat> StatsList => new(_stats);

        private void Awake()
        {
            stat = DataManager.Instance.GetStat(key);

            Health = new Stat(stat.hp, StatType.HP);
            Attack = new Stat(stat.attack, StatType.Attack);
            MoveSpeed = new Stat(stat.moveSpeed, StatType.MoveSpeed);
            AttackSpeed = new Stat(stat.attackSpeed, StatType.AttackSpeed);
            
            _stats.Add(Health);
            _stats.Add(Attack);
            _stats.Add(MoveSpeed);
            _stats.Add(AttackSpeed);
        }

        public Stat GetStat(StatType statType)
        {
            return _stats.FirstOrDefault(s => s.statType == statType);
        }
    }
}