using System;

namespace DNA
{
    [Serializable]
    public class Modifier
    {
        public StatType statType;
        public int modifierValue;
        public bool isFlatPercentage = false;
    }
}