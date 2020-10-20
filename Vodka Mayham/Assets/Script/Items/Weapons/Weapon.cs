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
        public abstract string weaponSprite { get; }
        public abstract void OnShooting();

        public int currentAmmoInClip { get; set; }
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

        public void Shoot() 
        {
            if (reloading)
                return;

            currentAmmoInClip--;
            OnShooting();

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

