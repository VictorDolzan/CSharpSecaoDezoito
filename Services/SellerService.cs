using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpSecaoDezoito.Data;
using CSharpSecaoDezoito.Models;

namespace CSharpSecaoDezoito.Services
{
    public class SellerService
    {
        private readonly CSharpSecaoDezoitoContext _context;

        public SellerService(CSharpSecaoDezoitoContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}