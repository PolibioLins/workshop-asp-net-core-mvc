using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Secao_17___SalesWEBMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Secao_17___SalesWEBMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWEBMVCContext _context;

        public DepartmentService(SalesWEBMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    


    }
}
