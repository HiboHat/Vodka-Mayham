using UnityEngine;

namespace Weapons
{
    public abstract class Weapon
    {
        public abstract string name { get; }
        public abstract float damage { get; }
        public abstract float headHitMultiplier { get; }
        public abstract float armorPenetration { get; }
        public abstract int ammoCapacity { get; }
        public abstract float reloadTime { get; }
        public abstract bool needReloading { get; }
        public abstract float fireRate { get; }
        public abstract string weaponSprite { get; }
        public abstract void OnShooting(Transform _firepoint, int _layermask);

        public int currentAmmoInClip { get; private set; }
        public float currentFireRate { get; set; } = 0;
        public bool reloading { get; set; } = false;

        protected Weapon() 
        {
            currentAmmoInClip = ammoCapacity;
        }
        protected Weapon(int _ammoInClip) 
        {
            if (_ammoInClip > ammoCapacity || _ammoInClip < 0)
                currentAmmoInClip = ammoCapacity;
            else
                currentAmmoInClip = _ammoInClip;
        }

        public void Shoot(Transform _firepoint, int _layermask = 2) 
        {
            if (reloading || currentFireRate < fireRate)
                return;

            currentAmmoInClip--;
            currentFireRate = 0;
            OnShooting(_firepoint, _layermask);

            if (currentAmmoInClip <= 0 && needReloading)
                Reload();
        }

        public void Reload() 
        {
            Debug.Log("Reloading...");
            reloading = true;
            Timer.StartFunction(action: () =>
            {
                reloading = false;
                currentAmmoInClip = ammoCapacity;
                Debug.Log("Reloaded!");
            }, time: reloadTime);
        }
    }
}

