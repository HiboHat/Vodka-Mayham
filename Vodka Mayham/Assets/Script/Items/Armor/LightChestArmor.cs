using Armor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChestArmor : IArmor
{
    public override string name { get; set; } = "Light Chest Armour";

    public override float durability { get; set; } = 10f;

    public override float armor { get; set; } = 20f;

    public override int armorType { get; set; } = 1;

    public override bool canBreak { get; set; } = true;
}
