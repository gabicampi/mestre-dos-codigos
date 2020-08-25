using System;
using System.Collections.Generic;
using System.Linq;

namespace AtividadeConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaValores = new List<int>();
            Console.WriteLine(".::. Soma dos pares .::.\n");
            Console.WriteLine("Digite o primeiro número: \n");
            listaValores.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o segundo número: \n");
            listaValores.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o terceiro número: \n");
            listaValores.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o quarto número: \n");
            listaValores.Add(int.Parse(Console.ReadLine()));

            int soma = 0;

            foreach (var numero in listaValores.Where(x => x%2 == 0))
            {
                soma += numero;
            }

            Console.WriteLine($"A soma dos pares é: {soma}\n");
            Console.WriteLine($"\nPressione qualquer botão para sair\n");
            Console.ReadKey();
        }
    }
}
