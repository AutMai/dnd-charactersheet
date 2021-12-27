namespace Model.Entities
{
    public partial class ELanguage
    {
        public ELanguage()
        {
            Characters = new HashSet<Character>();
            Races = new HashSet<Race>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<Race> Races { get; set; }
    }
}
