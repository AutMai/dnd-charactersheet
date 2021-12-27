namespace Model.Entities
{
    public partial class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; } = null!;
        public sbyte Proficient { get; set; }
        public int AbilityId { get; set; }

        public virtual Ability Ability { get; set; } = null!;
        public virtual ESkillName NameNavigation { get; set; } = null!;
    }
}
