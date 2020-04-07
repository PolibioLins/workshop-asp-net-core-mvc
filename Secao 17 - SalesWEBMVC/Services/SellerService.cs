using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Secao_17___SalesWEBMVC.Models;

namespace Secao_17___SalesWEBMVC.Services
{
    public class SellerService
    {
        private readonly SalesWEBMVCContext _context;

        public SellerService (SalesWEBMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();


        }

    }
}
