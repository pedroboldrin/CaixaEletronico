using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoCaixaEletronico.Models
{
    public class Saque
    {
        public Saque()
        {
            Hora = DateTime.Now;
        }

        public int Id { get; set; }
        public string Notas { get; set; }
        public int Valor { get; set; }
        public DateTime Hora { get; set; }
    }
}
