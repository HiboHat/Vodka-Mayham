using Weapons;
public abstract class DestroyableObject
{
    public abstract float health { get; }
    public abstract void OnHit(Weapon weapon);
}
