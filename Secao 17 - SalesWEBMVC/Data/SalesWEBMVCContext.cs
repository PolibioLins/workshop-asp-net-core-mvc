using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Secao_17___SalesWEBMVC.Models;

    public class SalesWEBMVCContext : DbContext
    {
        public SalesWEBMVCContext (DbContextOptions<SalesWEBMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Secao_17___SalesWEBMVC.Models.Department> Department { get; set; }
    }
