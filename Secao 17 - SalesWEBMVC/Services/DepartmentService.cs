using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Secao_17___SalesWEBMVC.Models;

namespace Secao_17___SalesWEBMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWEBMVCContext _context;

        public DepartmentService(SalesWEBMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }



    }
}
