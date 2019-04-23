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
        public static void Main(string[] args)
        {
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            Designer pedro = new Designer("833.222.048-39", 3000);
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04", 5000);
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53", 2000);
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89", 4000);
            camila.Nome = "Camila";

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de bonificação no mês: {0}", gerenciador.GetTotalBonificacao());
        }
    }
}
