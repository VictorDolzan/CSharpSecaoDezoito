using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CSharpSecaoDezoito.Models
{
    public class CSharpSecaoDezoitoContext : DbContext
    {
        public CSharpSecaoDezoitoContext (DbContextOptions<CSharpSecaoDezoitoContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}