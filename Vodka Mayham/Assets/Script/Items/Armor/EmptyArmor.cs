
namespace Armor 
{
    public class EmptyArmor : IArmor 
    {
        public override string name { get; set; } = "Empty";
        public override float durability { get; set; } = 0;
        public override float armor { get; set; } = 0;
        public override int armorType { get; set; } = 3;
        public override bool canBreak { get; set; } = false;
    }
}
