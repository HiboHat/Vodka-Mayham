using UnityEngine;

namespace Weapons
{
    public class TestGun : Weapon
    {
        public override string name { get; } = "Test Gun";
        public override float damage { get; } = 10f;
        public override float headHitMultiplier { get; } = 1.6f;
        public override float armorPenetration { get; } = 1f;
        public override int ammoCapacity { get; } = 15;
        public override float reloadTime { get; } = 3f;
        public override bool needReloading { get; } = true;
        public override string weaponSprite { get; } = "testGun";
        public override void OnShooting()
        {
            Debug.Log($"Shooting, Ammo {currentAmmoInClip} / {ammoCapacity}");
        }

        public TestGun(int _ammoInClip) : base(_ammoInClip) {}
    }
}
