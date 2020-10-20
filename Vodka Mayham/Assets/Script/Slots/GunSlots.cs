using Weapons;
using UnityEngine;

public class GunSlots : MonoBehaviour
{
    [SerializeField] private SpriteRenderer gunRenderer = null;

    private Weapon noWeapon = new Fist();
    public Weapon equippedWeapon { get; private set; } = new TestGun(-1);

    public Weapon[] weaponslots = new Weapon[4];

    public void SwapWeapon(int weapon)
    {
        if (weapon <= 3 && weapon >= 0) 
        {
            equippedWeapon = weaponslots[weapon];
            gunRenderer.sprite = SpriteLibrary.Get(equippedWeapon.weaponSprite);
        }
    }

    void Start()
    {
        weaponslots[0] = new TestGun(-1);
        weaponslots[1] = new Fist();
        weaponslots[2] = new Fist();
        weaponslots[3] = new Fist();

        equippedWeapon = noWeapon;
        gunRenderer.sprite = SpriteLibrary.Get(equippedWeapon.weaponSprite);
    }

    void Update()
    {
        if (equippedWeapon.currentFireRate <= equippedWeapon.fireRate) 
            equippedWeapon.currentFireRate += Time.deltaTime;
    }
}
