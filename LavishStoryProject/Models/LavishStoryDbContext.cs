
namespace LavishStoryProject.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    public class LavishStoryDbContext : IdentityDbContext<ApplicationUser>
    {
        public LavishStoryDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static LavishStoryDbContext Create()
        {
            return new LavishStoryDbContext();
        }
    }
}