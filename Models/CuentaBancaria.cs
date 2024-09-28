using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pc2.Models
{
    [Table("t_cuenta_bancaria")]
    public class CuentaBancaria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public decimal? Saldo { get; set; }
        public string? Email { get; set; }

    }
}