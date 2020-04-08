using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Secao_17___SalesWEBMVC.Models;
using Microsoft.EntityFrameworkCore;
using Secao_17___SalesWEBMVC.Exceptions;

namespace Secao_17___SalesWEBMVC.Services
{
    public class SellerService
    {
        private readonly SalesWEBMVCContext _context;

        public SellerService (SalesWEBMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllSync()
        {
            return await _context.Seller.ToListAsync();


        }
        public async Task InsertAsync (Seller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {

            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException)
            {
                throw new IntegrityException("Can't delete: The Seller has sales");
            }
           
        }
        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);

            if (!hasAny)
            {
                throw new NotFoundException("Id  not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }

            catch(DBConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }



        }

    }
}
