using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapons
{
    public class TestRifle : Weapon
    {
        public override string name { get; } = "Test Rifle";

        public override float damage { get; } = 5;

        public override float headHitMultiplier { get; } = 1.5f;

        public override float armorPenetration { get; } = 6f;

        public override int ammoCapacity { get; } = 30;

        public override float reloadTime { get; } = 2.3f;

        public override bool needReloading { get; } = true;

        public override float fireRate { get; } = 0.04f;

        public override string weaponSprite { get; } = "testRifle";

        public override Vector2 shootPoint { get; } = new Vector2(1.9f, 0);

        public override FireMode currentFireMode { get; set; } = FireMode.burst;

        public override void OnShooting(Transform _firepoint, int _layerMask)
        {
            Debug.Log($"Shooting, Ammo {currentAmmoInClip} / {ammoCapacity}");

            Vector3 shootDir = (_firepoint.position - InputListener.MouseScreenPosition()).normalized * -1;

            RaycastHit2D raycast = Physics2D.Raycast(origin: _firepoint.position, direction: shootDir, distance: 100f, _layerMask);

            Entity target;
            if (raycast)
            {
                target = raycast.transform.GetComponent<Entity>();
                if (target)
                    target.OnHit(this);
            }
        }

        public override void ToggleFireMode()
        {
            switch (currentFireMode) 
            {
                case FireMode.auto:
                    currentFireMode = FireMode.single;
                    break;
                case FireMode.single:
                    currentFireMode = FireMode.burst;
                    break;
                case FireMode.burst:
                    currentFireMode = FireMode.auto;
                    break;
            }
        }

        public TestRifle(int _ammoInClip) : base(_ammoInClip) { }
    }
}