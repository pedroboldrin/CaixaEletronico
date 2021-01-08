using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoCaixaEletronico.Models
{
    public class Cedulas
    {
        public int Id { get; set; }
        public string Nota { get; set; }
        public int Qtd { get; set; }
    }
}
