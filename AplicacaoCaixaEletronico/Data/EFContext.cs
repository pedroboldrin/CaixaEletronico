using AplicacaoCaixaEletronico.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoCaixaEletronico.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {

        }

        public DbSet<Cedulas> Cedulas { get; set; }

        public DbSet<Saque> Saque { get; set; }
    }
}
