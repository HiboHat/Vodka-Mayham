using Armor;
using Weapons;
using UnityEngine;

public class ArmorSlots : MonoBehaviour
{

    private IArmor noArmor = new EmptyArmor();
    public IArmor equippedArmor { get; private set; } = new EmptyArmor();

    public void Start()
    {
        
    }

    public void Equip(IArmor _armor) 
    {
        equippedArmor = _armor;
    }
}
