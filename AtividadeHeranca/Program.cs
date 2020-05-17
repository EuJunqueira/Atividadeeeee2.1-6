using System;

namespace AtividadeHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor f = new Fornecedor("FILIPE", "VARGINHA", "(35)3212-1480");
            f.ValorCredito = 1000.00;
            f.ValorDivida = 316.12;
            Console.WriteLine("FORNECEDOR, SALDO DE  :" + f.obterSaldo());

            Colaborador c = new Colaborador("NUBIA", "VARGINHA", "(35)3222-3344");
            c.CodSetor = 30;
            c.SalarioBase = 818.13;
            c.Impostos = 2;
            Console.WriteLine("COLABORADOR, SALARIO :" + c.calcularSalario());

            Administrador a = new Administrador("MATHEUS", "BOA ESPERANÇA", "(35)3851-2040");
            a.CodSetor = 30;
            a.SalarioBase = 818.13;
            a.Impostos = 2;
            a.AjudaDeCusto = 314.07;
            Console.WriteLine("ADMINISTRADOR, SALARIO :" + a.calcularSalario());

            Operario o = new Operario("JUNQUEIRA", "SAO PAULO", "(19)8878-1469");
            o.CodSetor = 30;
            o.SalarioBase = 818.13;
            o.Impostos = 2;
            o.ValorProducao = 117.09;
            o.Comissao = 3;
            Console.WriteLine("OPERARIO, SALARIO :" + o.calcularSalario());

            Vendedor v = new Vendedor("GONÇALVES", "BOA ESPERANÇA", "(35)3222-1499");
            v.CodSetor = 30;
            v.SalarioBase = 818.14;
            v.Impostos = 2;
            v.ValorVendas = 518.14;
            v.Comissao = 5;
            Console.WriteLine("VENDEDOR, SALARIO : " + v.calcularSalario());

            Console.ReadKey();
        }
    }
}