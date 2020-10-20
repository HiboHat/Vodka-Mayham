using UnityEngine;
using Armor;
using Weapons;

[System.Serializable]
public class Player : IEntity
{
    [SerializeField] private ArmorSlots armorSlots = null;
    [SerializeField] private GunSlots gunSlots = null;
    public override float health { get; set; } = 300f;

    public override void OnHit(Weapon weapon)
    {
        health -= armorSlots.equippedArmor.ArmorResistence(weapon);
        Debug.Log($"Health : {health}");
    }

    public void Fire()
    {
        gunSlots.equippedWeapon.Shoot();
    }
    public void OnDeath()
    {

    }

    public ArmorSlots GetArmorSlots() 
    {
        return armorSlots;
    }

    public GunSlots GetGunSlots() 
    {
        return gunSlots;
    }
}
