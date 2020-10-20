using UnityEngine;
using Weapons;
using Armor;
public abstract class IEntity : MonoBehaviour
{
    public abstract float health { get; set; }
    public abstract void OnHit(Weapon weapon);
}
