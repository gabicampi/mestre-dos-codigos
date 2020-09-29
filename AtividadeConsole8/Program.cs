using System;
using System.Collections.Generic;

namespace AtividadeConsole8
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<decimal>();
            int opt;
            do
            {
                Console.Clear();
                Console.WriteLine(".::. Crescente e decrescente .::.\n");
                Console.WriteLine("1- Adicionar um valor \n2- Mostrar valores em ordem crescente \n3- Mostrar valores em ordem decrescente \n0- Sair");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        AdicionarValor(lista);
                        break;
                    case 2:
                        MostrarOrdemCrescente(lista);
                        break;
                    case 3:
                        MostrarOrdemDecrescente(lista);
                        break;
                    default:
                        break;
                }
            } while (opt != 0);

        }

        private static void AdicionarValor(List<decimal> lista)
        {
            Console.Clear();
            Console.WriteLine("Digite o valor para inserir: ");
            lista.Add(decimal.Parse(Console.ReadLine()));
        }

        public static void MostrarOrdemDecrescente(List<decimal> lista)
        {
            Console.Clear();
            Console.WriteLine(".::. Ordem Decrescente .::.\n");
            lista.Sort((a, b) => b.CompareTo(a));
            lista.ForEach(x => Console.WriteLine($"{x}"));

            Console.WriteLine("\nAperte qualquer botao para voltar ao menu.\n");
            Console.ReadKey();
        }

        public static void MostrarOrdemCrescente(List<decimal> lista)
        {
            Console.Clear();
            Console.WriteLine(".::. Ordem Crescente .::.\n");
            lista.Sort((a, b) => a.CompareTo(b));
            lista.ForEach(x => Console.WriteLine($"{x} "));

            Console.WriteLine("\nAperte qualquer botao para voltar ao menu.\n");
            Console.ReadKey();
        }
    }
}
