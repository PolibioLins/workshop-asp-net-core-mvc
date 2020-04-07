using System.Collections.Generic;
using System;
using System.Linq;


namespace Secao_17___SalesWEBMVC.Models
{
    public class Department
     {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() {   }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSesler(Seller seller)
        {
            Sellers.Add(seller);
        }
      public double TotalSales(DateTime InitialDate,DateTime FinalDate)
        {
            return Sellers
                .Sum(Seller => Seller.TotalSales(InitialDate,FinalDate));

        }


    }
}
