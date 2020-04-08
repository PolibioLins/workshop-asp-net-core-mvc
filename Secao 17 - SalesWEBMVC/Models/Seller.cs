using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Secao_17___SalesWEBMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
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
