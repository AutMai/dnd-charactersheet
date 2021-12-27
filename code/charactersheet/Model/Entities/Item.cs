using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Item
    {
        public Item()
        {
            CharactersHasItems = new HashSet<CharactersHasItem>();
        }

        public int ItemId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public int Weight { get; set; }

        public virtual Armor Armor { get; set; } = null!;
        public virtual Weapon Weapon { get; set; } = null!;
        public virtual ICollection<CharactersHasItem> CharactersHasItems { get; set; }
    }
}
