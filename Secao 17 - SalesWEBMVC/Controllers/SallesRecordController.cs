using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Secao_17___SalesWEBMVC.Services;

namespace Secao_17___SalesWEBMVC.Controllers
{
    public class SallesRecordController : Controller
    {
        private readonly SallesRecordService _sallesRecordService;

        public SallesRecordController(SallesRecordService sallesRecordService)
        {
            _sallesRecordService = sallesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task <IActionResult> SimpleSearch(DateTime? minDate, DateTime ? maxDate)
        {
            if(!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = new DateTime(DateTime.Now.Year, 1, 1);
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = minDate.Value.ToString("yyyy-MM-dd");

            var result = await _sallesRecordService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}