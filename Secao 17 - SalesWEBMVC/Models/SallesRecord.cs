using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Secao_17___SalesWEBMVC.Models.Enums;

namespace Secao_17___SalesWEBMVC.Models
{
    public class SallesRecord
{
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SallesRecord() { }

        public SallesRecord(int id, DateTime date, double amount, SalleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
