using Weapons;
using UnityEngine;

public class GunSlots : MonoBehaviour
{
    [SerializeField] private SpriteRenderer gunRenderer = null;

    private Weapon noWeapon = new Fist();
    public Weapon equippedWeapon { get; private set; } = new TestGun(-1);

    public void SwapWeapon(Weapon weapon)
    {
        equippedWeapon = weapon;
        gunRenderer.sprite = SpriteLibrary.Get(equippedWeapon.weaponSprite);
    }

    void Start()
    {
        gunRenderer.sprite = SpriteLibrary.Get(equippedWeapon.weaponSprite);
    }

    void Update()
    {
        
    }
}
