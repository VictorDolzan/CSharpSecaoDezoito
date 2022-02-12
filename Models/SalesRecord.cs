using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSharpSecaoDezoito.Models.Enums;

namespace CSharpSecaoDezoito.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller SellerSR { get; set; }

        public SalesRecord()
        {            
        }

        public SalesRecord(int externalId, DateTime externalDate, double externalAmount, SaleStatus externalStatus, Seller externalSeller)
        {
            Id = externalId;
            Date = externalDate;
            Amount = externalAmount;
            Status = externalStatus;
            SellerSR = externalSeller;
        }
    }
}