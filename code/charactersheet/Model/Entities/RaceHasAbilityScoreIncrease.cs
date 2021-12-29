using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class RaceHasAbilityScoreIncrease
    {
        public int RaceId { get; set; }
        public string AbilityName { get; set; } = null!;
        public int Increase { get; set; }

        public virtual EAbilityName AbilityNameNavigation { get; set; } = null!;
        public virtual Race Race { get; set; } = null!;
    }
}
