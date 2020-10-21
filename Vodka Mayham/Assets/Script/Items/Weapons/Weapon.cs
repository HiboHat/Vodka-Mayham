using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;

namespace Weapons
{
    public abstract class Weapon
    {
        public enum FireMode
        {
            single,
            burst,
            auto
        }
        public abstract string name { get; }
        public abstract float damage { get; }
        public abstract float headHitMultiplier { get; }
        public abstract float armorPenetration { get; }
        public abstract int ammoCapacity { get; }
        public abstract float reloadTime { get; }
        public abstract bool needReloading { get; }
        public abstract float fireRate { get; }
        public abstract string weaponSprite { get; }
        public abstract Vector2 shootPoint { get; }
        public abstract FireMode currentFireMode { get; set; }
        public abstract void OnShooting(Transform _firepoint, int _layermask);
        public abstract void ToggleFireMode();

        public int currentAmmoInClip { get; private set; }
        public int fireCount { get; set; } = 0;
        public float currentFireRate { get; set; } = 0;
        public bool reloading { get; set; } = false;
        public bool triggerIsPressed { get; set; } = false;
        public const float firePerBurst = 3;

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

            if (currentAmmoInClip <= 0 && needReloading) 
            {
                Reload();
                return;
            }

            switch (currentFireMode) 
            {
                case FireMode.auto:
                    if (currentFireRate >= fireRate) 
                        break;
                    return;

                case FireMode.burst:
                    if (currentFireRate >= fireRate && fireCount < firePerBurst)    
                        break;
                    return;

                case FireMode.single:
                    if (currentFireRate >= fireRate && !triggerIsPressed)
                        break;
                    return;

            }
            currentAmmoInClip--;
            currentFireRate = 0;
            fireCount++;
            OnShooting(_firepoint, _layermask);

            triggerIsPressed = true;
        }

        public void ResetFireCount() 
        {
            triggerIsPressed = false;
            fireCount = 0;
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
            }, time: reloadTime, functionName: "ReloadTimer");
        }
    }
}

