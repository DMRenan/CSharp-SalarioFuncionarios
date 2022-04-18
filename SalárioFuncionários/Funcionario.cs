using System;
using System.Collections.Generic;
using System.Text;

namespace SalárioFuncionários
{
    internal class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int iD, string nome, double salario)
        {
            ID = iD;
            Nome = nome;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"Nome: {Nome},   ID: {ID},   Salário: {Salario}";
        }

        public void Aumento(double aumentoPercentual)
        {
            Salario *= (100 + aumentoPercentual) / 100;
        }
    }
}
