using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CSharpSecaoDezoito.Models;

namespace CSharpSecaoDezoito.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics"});
            list.Add(new Department { Id = 2, Name = "Fashion"});
            list.Add(new Department { Id = 3, Name = "Computers"});

            return View(list);
        }
    }
}