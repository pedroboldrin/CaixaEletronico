using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicacaoCaixaEletronico.Data;
using AplicacaoCaixaEletronico.Models;

namespace AplicacaoCaixaEletronico.Algoritmo
{
    public class Calculo : IServices
    {
        private Cedulas pegarCedulas;

        public int VerficaSaldo(List<Cedulas> notas)
        {
            var Qtd200 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "200").Single();
            Qtd200 = pegarCedulas.Qtd;

            var Qtd100 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "100").Single();
            Qtd100 = pegarCedulas.Qtd;

            var Qtd50 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "50").Single();
            Qtd50 = pegarCedulas.Qtd;

            var Qtd20 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "20").Single();
            Qtd20 = pegarCedulas.Qtd;

            var Qtd10 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "10").Single();
            Qtd10 = pegarCedulas.Qtd;

            var Qtd5 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "5").Single();
            Qtd5 = pegarCedulas.Qtd;

            var Qtd2 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "2").Single();
            Qtd2 = pegarCedulas.Qtd;

            var saldoCaixa = (200 * Qtd200) + (100 * Qtd100) + (50 * Qtd50) + (20 * Qtd20) + (10 * Qtd10) + (5 * Qtd5) + (2 * Qtd2);
            return saldoCaixa;
        }


        public string VerificaSaque(Saque saque, Cedulas cedulas, IQueryable<Cedulas> notas, EFContext context)
        {
            var Qtd200 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "200").Single();
            Qtd200 = pegarCedulas.Qtd;

            var Qtd100 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "100").Single();
            Qtd100 = pegarCedulas.Qtd;

            var Qtd50 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "50").Single();
            Qtd50 = pegarCedulas.Qtd;

            var Qtd20 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "20").Single();
            Qtd20 = pegarCedulas.Qtd;

            var Qtd10 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "10").Single();
            Qtd10 = pegarCedulas.Qtd;

            var Qtd5 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "5").Single();
            Qtd5 = pegarCedulas.Qtd;

            var Qtd2 = 0;
            pegarCedulas = notas.Where(a => a.Nota == "2").Single();
            Qtd2 = pegarCedulas.Qtd;

            var saldoCaixa = (200 * Qtd200) + (100 * Qtd100) + (50 * Qtd50) + (20 * Qtd20) + (10 * Qtd10) + (5 * Qtd5) + (2 * Qtd2);  
            var valorSaque = saque.Valor;

            if (valorSaque < 1000 && valorSaque >= 2 && valorSaque < saldoCaixa)
            {
                // 200
                if (valorSaque >= 200)
                {
                    var QtdNotas = valorSaque / 200;

                    if (Qtd200 >= QtdNotas)
                    {
                        valorSaque = valorSaque % 200;
                        Qtd200 -= QtdNotas;
                        saque.Notas += "Notas 200: " + QtdNotas + " - ";
                    }
                    else if (Qtd200 > 0)
                    {
                        valorSaque -= Qtd200 * 200;
                        saque.Notas += "Notas 200: " + Qtd200 + " - ";
                        Qtd200 -= Qtd200;
                    }
                }
                // 100
                if (valorSaque >= 100)
                {
                    var QtdNotas = valorSaque / 100;

                    if (Qtd100 >= QtdNotas)
                    {
                        valorSaque = valorSaque % 100;
                        Qtd100 -= QtdNotas;
                        saque.Notas += "Notas 100: " + QtdNotas + " - ";
                    }
                    else if (Qtd100 > 0)
                    {
                        valorSaque -= Qtd100 * 100;
                        saque.Notas += "Notas 100: " + Qtd100 + " - ";
                        Qtd100 -= Qtd100;
                    }
                }
                // 50
                if (valorSaque >= 50)
                {
                    var QtdNotas = valorSaque / 50;

                    if (Qtd50 >= QtdNotas)
                    {
                        valorSaque = valorSaque % 50;
                        Qtd50 -= QtdNotas;
                        saque.Notas += "Notas 50: " + QtdNotas + " - ";
                    }
                    else if (Qtd50 > 0)
                    {
                        valorSaque -= Qtd50 * 50;
                        saque.Notas += "Notas 50: " + Qtd50 + " - ";
                        Qtd50 -= Qtd50;
                    }
                }
                // 20
                if (valorSaque >= 20)
                {
                    var QtdNotas = valorSaque / 20;

                    if (Qtd20 >= QtdNotas)
                    {
                        valorSaque = valorSaque % 20;
                        Qtd20 -= QtdNotas;
                        saque.Notas += "Notas 20: " + QtdNotas + " - ";
                    }
                    else if (Qtd20 > 0)
                    {
                        valorSaque -= Qtd20 * 20;
                        saque.Notas += "Notas 20: " + Qtd20 + " - ";
                        Qtd20 -= Qtd20;
                    }
                }
                // 10
                if (valorSaque >= 10)
                {
                    var QtdNotas = valorSaque / 10;

                    if (Qtd10 >= QtdNotas)
                    {
                        valorSaque = valorSaque % 10;
                        Qtd10 -= QtdNotas;
                        saque.Notas += "Notas 10: " + QtdNotas + " - ";
                    }
                    else if (Qtd10 > 0)
                    {
                        valorSaque -= Qtd10 * 10;
                        saque.Notas += "Notas 10: " + Qtd10 + " - ";
                        Qtd10 -= Qtd10;
                    }
                }
                // 5
                if (valorSaque >= 5)
                {
                    var QtdNotas = valorSaque / 5;

                    if (Qtd5 >= QtdNotas)
                    {
                        valorSaque = valorSaque % 5;
                        Qtd5 -= QtdNotas;
                        saque.Notas += "Notas 5: " + QtdNotas + " - ";
                    }
                    else
                    {
                        valorSaque -= Qtd5 * 5;
                        saque.Notas += "Notas 5: " + Qtd5 + " - ";
                        Qtd5 -= Qtd5;
                    }
                }
                // 2
                if (valorSaque >= 2)
                {
                    var QtdNotas = valorSaque / 2;

                    if (Qtd2 >= QtdNotas)
                    {
                        valorSaque = valorSaque % 2;
                        Qtd2 -= QtdNotas;
                        saque.Notas += "Notas 2: " + QtdNotas + " - ";
                    }
                    else
                    {
                        valorSaque -= Qtd2 * 2;
                        saque.Notas += "Notas 2: " + Qtd2 + " - ";
                        Qtd2 -= Qtd2;
                    }
                }

            }
            else
            {
                if (valorSaque > 1000)
                {
                    var resultado = "Erro1";

                    return resultado;
                }
                else if (valorSaque < 2)
                {
                    var resultado = "Erro2";

                    return resultado;
                }
                else if (valorSaque > saldoCaixa)
                {
                    var resultado = "Erro3";

                    return resultado;
                }
            }

            if (valorSaque == 0)
            {
                // 200
                var cedulas200 = notas.Where(a => a.Nota == "200").Single();
                cedulas200.Qtd = Qtd200;
                context.Update(cedulas200);
                // 100
                var cedulas100 = notas.Where(a => a.Nota == "100").Single();
                cedulas100.Qtd = Qtd100;
                context.Update(cedulas100);
                // 50
                var cedulas50 = notas.Where(a => a.Nota == "50").Single();
                cedulas50.Qtd = Qtd50;
                context.Update(cedulas50);
                // 20
                var cedulas20 = notas.Where(a => a.Nota == "20").Single();
                cedulas20.Qtd = Qtd20;
                context.Update(cedulas20);
                // 10
                var cedulas10 = notas.Where(a => a.Nota == "10").Single();
                cedulas10.Qtd = Qtd10;
                context.Update(cedulas10);
                // 5
                var cedulas5 = notas.Where(a => a.Nota == "5").Single();
                cedulas5.Qtd = Qtd5;
                context.Update(cedulas5);
                // 2
                var cedulas2 = notas.Where(a => a.Nota == "2").Single();
                cedulas2.Qtd = Qtd2;
                context.Update(cedulas2);

                string resultado;
                if (saque.Notas != null && saque.Hora != null)
                {

                    context.Update(saque);
                    context.SaveChanges();
                    resultado = "Sucesso";
                }
                else
                {
                    resultado = "Erro4";
                }

                return resultado;

            }
            else
            {
                return valorSaque.ToString();
            }
        }
    }
}
