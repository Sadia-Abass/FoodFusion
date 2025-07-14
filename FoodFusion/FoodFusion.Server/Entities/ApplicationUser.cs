﻿using Microsoft.AspNetCore.Identity;

namespace FoodFusion.Server.Entities
{
    public class ApplicationUser : IdentityUser 
    {
        //public string UserType { get; set; } = string.Empty;

        public virtual Customer Customer { get; set; } = new Customer();
        public virtual Employee Employee { get; set; } = new Employee();
        public virtual ICollection<ApplicationUserClaim>? Claims { get; set; }
        public virtual ICollection<ApplicationUserLogin>? Logins { get; set; }
        public virtual ICollection<ApplicationUserToken>? Tokens { get; set; }
        public virtual ICollection<ApplicationUserRole>? UserRoles { get; set; }
    }

    public class ApplicationRole : IdentityRole
    {
       // public string Description { get; set; } = string.Empty;
        public virtual ICollection<ApplicationUserRole>? UserRoles { get; set; }
        public virtual ICollection<ApplicationRoleClaim>? RoleClaims { get; set; }
    }

    public class ApplicationUserRole : IdentityUserRole<String>
    {
        public virtual ApplicationUser? User { get; set; }
        public virtual ApplicationRole? Role { get; set; }
    }

    public class ApplicationUserClaim : IdentityUserClaim<string>
    {
        public virtual ApplicationUser? User { get; set; }
    }

    public class ApplicationUserLogin : IdentityUserLogin<string>
    {
        public virtual ApplicationUser? User { get; set; }
    }

    public class ApplicationRoleClaim : IdentityRoleClaim<string>
    {
        public virtual ApplicationRole? Role { get; set; }
    }

    public class ApplicationUserToken : IdentityUserToken<string>
    {
        public virtual ApplicationUser? User { get; set; }
    }
}
