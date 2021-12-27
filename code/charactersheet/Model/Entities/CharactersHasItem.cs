namespace Model.Entities
{
    public partial class CharactersHasItem
    {
        public int CharacterId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }

        public virtual Character Character { get; set; } = null!;
        public virtual Item Item { get; set; } = null!;
    }
}
