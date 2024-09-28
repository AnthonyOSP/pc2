using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pc2.Models;

namespace pc2.ViewModel
{
    public class CuentaCBViewModel
    {
        public CuentaBancaria? FormCuenta { get; set; }
        public IEnumerable<CuentaBancaria>? ListCuenta { get; set; }
    }

    public class FormCuenta
    {
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? Tipo { get; set; }
        public decimal? Saldo { get; set; }
    }
}