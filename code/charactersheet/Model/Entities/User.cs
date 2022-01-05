using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class User
    {
        public User()
        {
            Characters = new HashSet<Character>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Character> Characters { get; set; }
    }
}
