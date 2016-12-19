using Microsoft.AspNet.Identity.EntityFramework;
using Phase4.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phase4.Web.DataContexts
{
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static IdentityDb Create()
        {
            return new IdentityDb();
        }
    }
}