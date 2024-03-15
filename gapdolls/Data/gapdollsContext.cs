using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gapdolls.Models;

namespace gapdolls.Data
{
    public class gapdollsContext : DbContext
    {
        public gapdollsContext (DbContextOptions<gapdollsContext> options)
            : base(options)
        {
        }

        public DbSet<gapdolls.Models.Dolls> Dolls { get; set; } = default!;
    }
}
