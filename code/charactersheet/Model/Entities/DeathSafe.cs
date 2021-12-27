using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class DeathSafe
    {
        public int CharacterId { get; set; }
        public sbyte Success { get; set; }
        public short Count { get; set; }

        public virtual Character Character { get; set; } = null!;
    }
}
