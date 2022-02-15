using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpSecaoDezoito.Data;
using CSharpSecaoDezoito.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpSecaoDezoito.Services
{
    public class DepartmentService
    {
        private readonly CSharpSecaoDezoitoContext _context;

        public DepartmentService(CSharpSecaoDezoitoContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
        
    }
}