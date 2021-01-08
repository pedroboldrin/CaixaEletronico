using AplicacaoCaixaEletronico.Data;
using AplicacaoCaixaEletronico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoCaixaEletronico.Algoritmo
{
    public interface IServices
    {
        public string VerificaSaque(Saque saque, Cedulas cedulas, IQueryable<Cedulas> notas, EFContext context);
        public int VerficaSaldo(List<Cedulas> notas);
    }
}
