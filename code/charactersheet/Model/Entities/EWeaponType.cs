namespace Model.Entities
{
    public partial class EWeaponType
    {
        public EWeaponType()
        {
            Weapons = new HashSet<Weapon>();
        }

        public int Name { get; set; }

        public virtual ICollection<Weapon> Weapons { get; set; }
    }
}
