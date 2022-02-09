using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSharpSecaoDezoito.Models;
using CSharpSecaoDezoito.Models.ViewModels;

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