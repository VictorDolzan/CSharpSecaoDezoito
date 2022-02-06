using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CSharpSecaoDezoito.Data
{
    class CSharpSecaoDezoitoContext : DbContext
    {
        private readonly string _connectionString;
        public CSharpSecaoDezoitoContext (DbContextOptions<CSharpSecaoDezoitoContext> options)
            : base(options)
        {
        } 

        public DbSet<CSharpSecaoDezoito.Models.Department> Department { get; set; }
        //public DbSet<Seller> Seller { get; set; }
        //public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}