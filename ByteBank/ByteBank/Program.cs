using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            //CalcularBonificacao();
            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04", 5000);
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89", 4000);
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "parceiro";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiro, "parceiro");
        }

        public static void CalcularBonificacao()
        {

            Diretor roberta = new Diretor("159.753.398-04", 5000);
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89", 4000);
            camila.Nome = "Camila";
            camila.Senha = "abc";

            Designer pedro = new Designer("833.222.048-39", 3000);
            pedro.Nome = "Pedro";

            Auxiliar igor = new Auxiliar("981.198.778-53", 2000);
            igor.Nome = "Igor";

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(camila);
            gerenciador.Registrar(pedro);
            gerenciador.Registrar(igor);

            Console.WriteLine("Total de bonificação no mês: {0}", gerenciador.GetTotalBonificacao());
        }
    }
}
