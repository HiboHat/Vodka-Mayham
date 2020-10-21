using Weapons;
using UnityEngine;

public class GunSlots : MonoBehaviour
{
    [SerializeField] private SpriteRenderer gunRenderer = null;
    [SerializeField] private Transform shootPoint = null;

    private Weapon noWeapon = new Fist();
    public Weapon equippedWeapon { get; private set; } = new TestGun(-1);

    public Weapon[] weaponslots = new Weapon[4];

    public void SwapWeapon(int weapon)
    {
        if (weapon <= 3 && weapon >= 0) 
        {
            if (equippedWeapon.reloading) 
            {
                Timer.StopTimer("ReloadTimer");
                equippedWeapon.reloading = false;
            }
            equippedWeapon = weaponslots[weapon];
            gunRenderer.sprite = SpriteLibrary.Get(equippedWeapon.weaponSprite);
            shootPoint.localPosition = (Vector2)transform.localPosition + equippedWeapon.shootPoint;
        }
    }

    public Transform ShootPoint() 
    {
        return shootPoint;
    }

    void Start()
    {
        weaponslots[0] = new TestRifle(-1);
        weaponslots[1] = new TestGun(-1);
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
