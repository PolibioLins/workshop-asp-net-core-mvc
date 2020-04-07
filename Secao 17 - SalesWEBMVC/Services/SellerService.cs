﻿using System;
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
        public void Inset (Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }


    }
}
