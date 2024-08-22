using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Caparace.Models;

namespace Caparace.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Caparace.Models.Product> Product { get; set; } = default!;
        public DbSet<Caparace.Models.Client> Client { get; set; } = default!;
    }
}
