using Microsoft.AspNetCore.Identity;
using Model.Entities;

namespace Model.Identity {
    public partial class ApplicationUser : IdentityUser {
        public ApplicationUser() {
            Characters = new HashSet<Character>();
        }
        public virtual ICollection<Character> Characters { get; set; }
    }
}