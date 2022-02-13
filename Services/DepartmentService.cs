using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpSecaoDezoito.Data;
using CSharpSecaoDezoito.Models;

namespace CSharpSecaoDezoito.Services
{
    public class DepartmentService
    {
        private readonly CSharpSecaoDezoitoContext _context;

        public DepartmentService(CSharpSecaoDezoitoContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
        
    }
}