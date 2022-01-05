using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace Model.Entities{
    public partial class ApplicationUser : IdentityUser{
        public ApplicationUser(){
            Characters = new HashSet<Character>();
        }

        public virtual ICollection<Character> Characters{ get; set; }
    }
}