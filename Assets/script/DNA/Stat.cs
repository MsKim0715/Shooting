using System;
using System.Collections.Generic;
using UnityEngine;

namespace DNA
{
    [Serializable]
    public class Stat
    {
        public Stat(int initialValue, StatType statType)
        {
            BaseValue = initialValue;
            this.statType = statType;
            value = BaseValue;
        }
        
        [field: SerializeField] public int BaseValue { get; private set; }
        [SerializeField] private int minimumValue;
        [SerializeField] private int maximumValue = int.MaxValue;
        [SerializeField] private List<Modifier> modifiers = new();

        public int value; 
        public StatType statType;
        
        public Action<Modifier> OnModifierAdded;

        
        private void Evaluate()
        {
            var scalingPercentage = 0;
            var flatPercentage = 0;

            foreach (var modifier in modifiers)
            {
                if (modifier.isFlatPercentage)
                {
                    flatPercentage += modifier.modifierValue;
                }
                else
                {
                    scalingPercentage += modifier.modifierValue;
                }
            }

            var scaledValue = BaseValue + BaseValue * (scalingPercentage / 100f);
            value = (int)Mathf.Clamp(scaledValue + flatPercentage, minimumValue, maximumValue);
        }

        public void Reset()
        {
            modifiers.Clear();
            value = BaseValue;
        }

        public void AddModifier(Modifier modifier)
        {
            modifiers.Add(modifier);
            Evaluate();
            OnModifierAdded?.Invoke(modifier);
        }
    }

}