using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using User.Models;

namespace User.Data
{
    public class GenderContext : DbContext
    {
        public GenderContext (DbContextOptions<GenderContext> options)
            : base(options)
        {
        }

        public DbSet<User.Models.Gender> Gender { get; set; }
    }
}
