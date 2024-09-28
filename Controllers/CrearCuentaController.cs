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
    public class CrearCuentaController : Controller
    {
        private readonly ILogger<CrearCuentaController> _logger;
        private readonly ApplicationDbContext _context;

        public CrearCuentaController(ILogger<CrearCuentaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(CuentaCBViewModel viewModel)
        {
            var cuentaBancaria = new CuentaBancaria
            {
                Nombre = viewModel.FormCuenta.Nombre,
                Email = viewModel.FormCuenta.Email,
                Tipo = viewModel.FormCuenta.Tipo,
                Saldo = viewModel.FormCuenta.Saldo
            };

            _context.Add(cuentaBancaria);
            _context.SaveChanges();

            TempData["Message"] = "Se creo la cuenta correctamente";
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}