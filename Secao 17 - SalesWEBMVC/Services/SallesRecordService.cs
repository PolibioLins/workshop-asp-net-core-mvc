using Secao_17___SalesWEBMVC.Models;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Secao_17___SalesWEBMVC.Services
{
    public class SallesRecordService
    {
        private readonly SalesWEBMVCContext _context;
        public SallesRecordService(SalesWEBMVCContext context)
        {
            _context = context;
        }
        public async Task<List<SallesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SallesRecord select obj;

            if (minDate.HasValue)

            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }


    }
}
