using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc2.Data;
using pc2.Models;
using pc2.ViewModel;

namespace pc2.Controllers
{

    public class ListarCBController : Controller
    {
        private readonly ILogger<ListarCBController> _logger;
        private readonly ApplicationDbContext _context;

        public ListarCBController(ILogger<ListarCBController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var miscontactos = from o in _context.DataCuenta select o;
            var viewModel = new CuentaCBViewModel
            {
                FormCuenta = new CuentaBancaria(),
                ListCuenta = [.. miscontactos.OrderBy(c => c.Id)]
            };
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}