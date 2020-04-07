using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Secao_17___SalesWEBMVC.Services;
using Secao_17___SalesWEBMVC.Models;
using Secao17SalesWEBMVC.Data;

namespace Secao_17___SalesWEBMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController (SellerService sellerService)
        {
            _sellerService = sellerService;
        }


        public IActionResult Index()
        {
            var list = _sellerService.FindAll();

            return View(list); 
        }
    }
}