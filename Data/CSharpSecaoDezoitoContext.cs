using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CSharpSecaoDezoito.Models
{
    class CSharpSecaoDezoitoContext : DbContext
    {
        public CSharpSecaoDezoitoContext (DbContextOptions<CSharpSecaoDezoitoContext> options)
            : base(options)
        {
        }

        public DbSet<CSharpSecaoDezoito.Models.Department> Department { get; set; }
    }
}