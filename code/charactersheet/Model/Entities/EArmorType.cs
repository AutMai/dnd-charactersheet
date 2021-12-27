namespace Model.Entities
{
    public partial class EArmorType
    {
        public EArmorType()
        {
            Armors = new HashSet<Armor>();
        }

        public string Label { get; set; } = null!;

        public virtual ICollection<Armor> Armors { get; set; }
    }
}
