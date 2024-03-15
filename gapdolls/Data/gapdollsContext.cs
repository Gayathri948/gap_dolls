using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gapdolls.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace gapdolls.Data
{
    public class gapdollsContext : IdentityDbContext
    {
        public gapdollsContext (DbContextOptions<gapdollsContext> options)
            : base(options)
        {
        }

        public DbSet<gapdolls.Models.Dolls> Dolls { get; set; } = default!;
       public DbSet<gapdolls.Models.Customer> Customers { get; set; }
    }
}
