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
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Cauê Nishijma";
            funcionario.CPF = "229.984.398-10";
            funcionario.Salario = 5000;

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.GetBonificacao());

            Diretor diretor = new Diretor();
            diretor.Nome = "Soraia";
            diretor.CPF = "568.251.261-20";
            diretor.Salario = 10000;
            Console.WriteLine(diretor.Nome);
            Console.WriteLine(diretor.GetBonificacao());


            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            gerenciadorBonificacao.Registrar(funcionario);
            gerenciadorBonificacao.Registrar(diretor);

            Console.WriteLine(gerenciadorBonificacao.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
