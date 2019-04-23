using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("229.984.398-10", 5000);
            funcionario.Nome = "Cauê Nishijma";

            funcionario.AumentarSalario();
            Console.WriteLine("Novo salário: " + funcionario.Salario);


            Console.WriteLine("Funcionário: " + funcionario.Nome);
            Console.WriteLine("Bonificação Funcionário: " + funcionario.GetBonificacao());

            Diretor diretor = new Diretor("568.251.261-20", 10000);
            diretor.Nome = "Soraia";
            diretor.AumentarSalario();

            Console.WriteLine("Novo salário: " + diretor.Salario);

            Console.WriteLine("Diretor: " + diretor.Nome);
            Console.WriteLine("Bonificação Diretor: " + diretor.GetBonificacao());


            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            gerenciadorBonificacao.Registrar(funcionario);
            gerenciadorBonificacao.Registrar(diretor);

            Console.WriteLine("Total de bonificação: " + gerenciadorBonificacao.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
