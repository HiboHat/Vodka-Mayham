using UnityEngine;
using Weapons;
using Armor;
public abstract class Entity : MonoBehaviour
{
    public abstract float health { get; set; }
    public abstract void OnHit(Weapon weapon);
    public void DestroyEntity() 
    {
        Object.Destroy(gameObject);
    }
}
