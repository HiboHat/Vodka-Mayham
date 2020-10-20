using UnityEngine;
using Weapons;

namespace Armor 
{
    public abstract class IArmor 
    {
        public abstract string name { get; set; }
        public abstract float durability { get; set; }
        public abstract float armor { get; set; }
        public abstract int armorType { get; set; }
        public abstract bool canBreak { get; set; }

        public float ArmorResistence(Weapon weapon)
        {
            float totaldamage = weapon.damage * (100 / (100 + armor));
            float damageReduction = weapon.damage - totaldamage;

            if (canBreak)
            {
                float durReduction = weapon.armorPenetration * (100 / (100 + armor));
                durability -= durReduction;

                if (durability <= 0)
                    Break();
                Debug.Log($"Armor durability : {durability} with reduction of {durReduction}");
            }

            Debug.Log($" Total damage : {weapon.damage - damageReduction} with reduction of {damageReduction}");
            return totaldamage;
        }

        private void Break()
        {

        }
    }

}