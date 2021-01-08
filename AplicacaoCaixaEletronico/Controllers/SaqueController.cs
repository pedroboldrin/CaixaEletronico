using AplicacaoCaixaEletronico.Algoritmo;
using AplicacaoCaixaEletronico.Data;
using AplicacaoCaixaEletronico.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
namespace AplicacaoCaixaEletronico.Controllers
{
    public class SaqueController : Controller
    {
        private readonly EFContext _context;
        private readonly IServices _interfaces;
        public SaqueController(EFContext context, IServices interfaces)
        {
            _context = context;
            _interfaces = interfaces;
        }

        public ActionResult Index()
        {
            List<Cedulas> lista = _context.Cedulas.ToList<Cedulas>();
            return View(lista);
        }
        public ActionResult Create()
        {
            var notas = _context.Cedulas.Where<Cedulas>(a => a.Nota != "").ToList();
            var saldo = _interfaces.VerficaSaldo(notas);
            ViewBag.Saldo = saldo;
            return View();
        }

        

        [HttpPost]
        public ActionResult Create(Saque saque, Cedulas cedulas)
        {
            var notas = _context.Cedulas.Where<Cedulas>(a => a.Nota != "");
            var response = _interfaces.VerificaSaque(saque, cedulas, notas, _context);

            if (response == "Sucesso")
            {
                ViewBag.Mensagem = "Saque de " + saque.Valor.ToString() + " reais realizado com sucesso!!! Deseja realizar um novo Saque ou voltar para o Inicio?";
                return View("Redirecionador");
            }
            else if (response == "Erro1")
            {
                ViewBag.Mensagem = "Erro ao tentar sacar " + saque.Valor.ToString() + " reais. O valor deve ser menor que 1000 reais!!! Deseja realizar um novo Saque ou voltar para o Inicio?";
                return View("Redirecionador");
            }
            else if (response == "Erro2")
            {
                ViewBag.Mensagem = "Erro ao tentar sacar " + saque.Valor.ToString() + " reais. O valor do saque deve ser maior que 2 reais!!! Deseja realizar um novo saque ou voltar para o Inicio?";
                return View("Redirecionador");
            }
            else if (response == "Erro3")
            {
                ViewBag.Mensagem = "Saldo do caixa insuficiente para realizar o saque com o valor solicitado!!! Deseja realizar um novo Saque ou voltar para o Inicio?";
                return View("Redirecionador");
            }
            else if (response == "Erro4")
            {
                ViewBag.Mensagem = "Erro no sistema!!! O saque não foi realizado, tente novamente. Se o erro persistir contate o Suporte. Deseja realizar um novo Saque ou voltar para o Inicio?";
                return View("Redirecionador");
            }
            else
            {
                ViewBag.Mensagem = "Notas insuficientes para realizar o saque de " + saque.Valor.ToString() + " reais, faltou " + response.FirstOrDefault() + " reais, para poder efutar o saque tente novamente subtraindo " + response.FirstOrDefault() + " real ou cancele a operacao. Deseja Tentar Novamente ou voltar para o Inicio?";
                return View("Redirecionador");
            }
        }
    }
}
