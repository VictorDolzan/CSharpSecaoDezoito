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
    }
}