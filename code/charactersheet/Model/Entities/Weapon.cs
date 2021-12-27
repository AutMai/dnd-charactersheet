namespace Model.Entities
{
    public partial class Weapon
    {
        public int WeaponId { get; set; }
        public int WeaponType { get; set; }
        public int DamageTypes { get; set; }
        public int DamageDieId { get; set; }

        public virtual Dicethrow DamageDie { get; set; } = null!;
        public virtual EDamageType DamageTypesNavigation { get; set; } = null!;
        public virtual Item WeaponNavigation { get; set; } = null!;
        public virtual EWeaponType WeaponTypeNavigation { get; set; } = null!;
    }
}
