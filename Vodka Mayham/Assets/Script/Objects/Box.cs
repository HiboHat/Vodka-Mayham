using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapons;

public class Box : Entity
{
    public override float health { get; set; } = 10;

    public override void OnHit(Weapon weapon)
    {
        health -= weapon.damage;
        if (health <= 0)
            DestroyEntity();
    }
}
