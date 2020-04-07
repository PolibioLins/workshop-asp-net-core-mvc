using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Secao_17___SalesWEBMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SallesRecord> Sales = new List<SallesRecord>();

        public Seller(){}

        public Seller(int id, string name, string email, DateTime date, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            Date = date;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales (SallesRecord sallesRecord )
        {
            Sales.Add(sallesRecord);
        }

        public void RemoveSales(SallesRecord sallesRecord)
        {
            Sales.Remove(sallesRecord);
        }

        public double TotalSales(DateTime InitailDate, DateTime FinalDate)
        {

            return Sales
                .Where(sr => sr.Date >= InitailDate && sr.Date <= FinalDate)
                .Sum(sr => sr.Amount);
        }



    }
}
