using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutCoach.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FutCoach.Models
{
    public class IdentityContext : IdentityDbContext<FutCoachUser>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {

        }
    }
}
