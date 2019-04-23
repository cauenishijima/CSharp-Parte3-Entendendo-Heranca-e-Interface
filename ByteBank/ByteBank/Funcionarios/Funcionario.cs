using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; } 
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;

            TotalFuncionarios++;
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
    }
}
