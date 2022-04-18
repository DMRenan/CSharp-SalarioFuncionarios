using System;
using System.Collections.Generic;
using System.Globalization;

namespace SalárioFuncionários
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Console.Write("Informe o número de funcionários: ");
            int numeroFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroFuncionarios; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"---Funcionario #{i}---");
                Console.Write("Insira o id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Insira o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Insira o salário: R$ ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine();
            Console.Write("Digite o id do funcionário que receberá aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario funcionarioAumento = funcionarios.Find(x => x.ID == idAumento);

            if (funcionarioAumento != null)
            {
                Console.Write("Insira o percentual de aumento: ");
                double aumentoPercentual = double.Parse(Console.ReadLine());
                funcionarioAumento.Aumento(aumentoPercentual);
            }
            else
            {
                Console.WriteLine($"O id {idAumento} não pertence a nenhum funcionário da lista.");
            }

            Console.WriteLine();
            Console.WriteLine("---Lista atualizada de funcionários---");
            foreach (Funcionario obj in funcionarios)
            {
                Console.WriteLine(obj);
                Console.WriteLine();
            }
        }
    }
}
