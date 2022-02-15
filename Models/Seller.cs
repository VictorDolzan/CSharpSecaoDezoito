using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSharpSecaoDezoito.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }


        [Display(Name = "Department")]
        public Department DepartmentS { get; set; }


        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {            
        }
        public Seller(int externalId, string externalName, string externalEmail, DateTime externalBirthDate, double externalBaseSalary, Department externalDepartment)
        {
            Id = externalId;
            Name = externalName;
            Email = externalEmail;
            BirthDate = externalBirthDate;
            BaseSalary = externalBaseSalary;
            DepartmentS = externalDepartment;           
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final)
            .Sum(sr => sr.Amount);
        }
    }   
}