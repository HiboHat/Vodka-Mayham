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
        public override float fireRate { get; } = 0.6f;
        public override bool needReloading { get; } = true;
        public override string weaponSprite { get; } = "testGun";
        public override Vector2 shootPoint { get; } = new Vector2(1, 0);
        public override FireMode currentFireMode { get; set; } = FireMode.single;
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

        public override void ToggleFireMode(){}

        public TestGun(int _ammoInClip) : base(_ammoInClip) {}
    }
}
