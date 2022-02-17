using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpSecaoDezoito.Data;
using CSharpSecaoDezoito.Models;
using Microsoft.EntityFrameworkCore;
using CSharpSecaoDezoito.Services.Exceptions;

namespace CSharpSecaoDezoito.Services
{
    public class SalesRecordService
    {
        private readonly CSharpSecaoDezoitoContext _context;

        public SalesRecordService(CSharpSecaoDezoitoContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if(minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if(maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
            .Include(x => x.SellerSR)
            .Include(x => x.SellerSR.DepartmentS)
            .OrderByDescending(x => x.Date)
            .ToListAsync();
        }
        public async Task<List<IGrouping<Department,SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.SellerSR)
                .Include(x => x.SellerSR.DepartmentS)
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.SellerSR.DepartmentS)
                .ToListAsync();
        }
        
    }
}