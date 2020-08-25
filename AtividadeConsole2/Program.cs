using System;
using System.Collections.Generic;

namespace AtividadeConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".::. Funcionários e salários .::.\n");
            Console.WriteLine("Digite o número de funcionários que deseja inserir.\n");
            int n = int.Parse(Console.ReadLine());

            var lista = new Funcionario[n];
            int contagem = 0;
            while (contagem < n)
            {
                Console.WriteLine($"Digite o nome do funcionário.\n");
                string nome = Console.ReadLine();
                Console.WriteLine($"Digite o salário do funcionário.\n");
                decimal salario = decimal.Parse(Console.ReadLine());

                lista[contagem] = new Funcionario 
                { 
                    Nome = nome,
                    Salario = salario 
                };

                contagem++;
            }
                Console.Clear();

            Funcionario menorSalario = lista[0];
            Funcionario maiorSalario = lista[0];

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i].Salario > maiorSalario.Salario)
                {
                    maiorSalario = lista[i];
                }

                if (lista[i].Salario < menorSalario.Salario)
                {
                    menorSalario = lista[i];
                }
            }

            Console.WriteLine($"O funcionario com maior salário é: {maiorSalario.Nome} - R$ {maiorSalario.Salario}\n");
            Console.WriteLine($"O funcionario com menor salário é: {menorSalario.Nome} - R$ {menorSalario.Salario}\n");
            Console.WriteLine("\naperte qualquer botão para finalizar\n");
            Console.ReadKey();
        }
    }

    public class Funcionario
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }
    }
}
