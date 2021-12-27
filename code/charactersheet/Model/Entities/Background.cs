namespace Model.Entities
{
    public partial class Background
    {
        public Background()
        {
            Characters = new HashSet<Character>();
        }

        public int BackgroundId { get; set; }
        public string Name { get; set; } = null!;
        public string SkillProficiencies { get; set; } = null!;

        public virtual ICollection<Character> Characters { get; set; }
    }
}
