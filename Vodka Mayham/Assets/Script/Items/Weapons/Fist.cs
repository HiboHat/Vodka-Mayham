using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapons
{
    public class Fist : Weapon
    {
        public override string name { get; } = "Fist";
        public override float damage { get; } = 1;
        public override float headHitMultiplier { get; } = 0;
        public override float armorPenetration { get; } = 0;
        public override int ammoCapacity { get; } = 0;
        public override float reloadTime { get; } = 0;
        public override float fireRate { get; } = 0.4f;
        public override bool needReloading { get; } = false;
        public override string weaponSprite { get; } = null;


        public override void OnShooting(Transform _firepoint, int _layermask)
        {
            Debug.Log($"PUNCH!");
        }
        public Fist() { }
    }

}
