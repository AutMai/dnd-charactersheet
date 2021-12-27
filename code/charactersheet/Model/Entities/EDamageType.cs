namespace Model.Entities
{
    public partial class EDamageType
    {
        public EDamageType()
        {
            Spells = new HashSet<Spell>();
            Weapons = new HashSet<Weapon>();
        }

        public int Name { get; set; }

        public virtual ICollection<Spell> Spells { get; set; }
        public virtual ICollection<Weapon> Weapons { get; set; }
    }
}
