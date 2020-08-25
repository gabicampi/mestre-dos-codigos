using System;
using System.Collections.Generic;
using System.Linq;

namespace AtividadeConsole9
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>();
            int opt;
            do
            {
                Console.Clear();
                Console.WriteLine(".::. Lista com LINQ .::.\n");
                Console.WriteLine("1- Mostrar todos os valores da lista \n" +
                    "2- Mostrar valores em ordem crescente \n" +
                    "3- Mostrar valores em ordem decrescente \n" +
                    "4- Mostrar o primeiro valor \n" +
                    "5- Mostrar o ultimo valor \n" +
                    "6- Inserir no inicio da lista \n" +
                    "7- Inserir no final da lista \n" +
                    "8- Remover o primeiro valor \n" +
                    "9- Remover o último valor \n" +
                    "10- Mostrar valores pares \n" +
                    "11- Pesquisar na lista \n" +
                    "12- Mostrar em array \n" +
                    "0- Sair");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        MostrarTodos(lista);
                        break;
                    case 2:
                        MostrarOrdemCrescente(lista);
                        break;
                    case 3:
                        MostrarOrdemDecrescente(lista);
                        break;
                    case 4:
                        MostrarPrimeiro(lista);
                        break;
                    case 5:
                        MostrarUltimo(lista);
                        break;
                    case 6:
                        AdicionarValorInicio(lista);
                        break;
                    case 7:
                        AdicionarValorFinal(lista);
                        break;
                    case 8:
                        RemoverPrimeiro(lista);
                        break;
                    case 9:
                        RemoverUltimo(lista);
                        break;
                    case 10:
                        MostrarPares(lista);
                        break;
                    case 11:
                        PesquisarNaLista(lista);
                        break;
                    case 12:
                        MostrarArray(lista);
                        break;
                    default:
                        break;
                }
            } while (opt != 0);

        }

        private static void MostrarArray(List<int> lista)
        {
            Console.Clear();
            Console.WriteLine("Mostrando em array\n");
            var array = lista.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Pressione qualquer botao para voltar ao menu");
            Console.ReadKey();
        }

        private static void AdicionarValorInicio(List<int> lista)
        {
            Console.Clear();
            Console.WriteLine("Digite o valor para inserir: ");
            var valor = int.Parse(Console.ReadLine());
            lista.Insert(0, valor);

            Console.WriteLine("Pressione qualquer botao para voltar ao menu");
            Console.ReadKey();
        }
        private static void AdicionarValorFinal(List<int> lista)
        {
            Console.Clear();
            Console.WriteLine("Digite o valor para inserir: ");
            lista.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Pressione qualquer botao para voltar ao menu");
            Console.ReadKey();
        }

        public static void MostrarTodos(List<int> lista)
        {
            Console.Clear();
            Console.WriteLine("Mostrando todos os valores.\n");
            lista.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Pressione qualquer botao para voltar ao menu");
            Console.ReadKey();
        }

        public static void MostrarPrimeiro(List<int> lista)
        {
            Console.Clear();
            Console.WriteLine("Mostrando o primeiro valor.\n");

            Console.WriteLine(lista.First());

            Console.WriteLine("Pressione qualquer botao para voltar ao menu");
            Console.ReadKey();
        }

        public static void MostrarUltimo(List<int> lista)
        {
            Console.Clear();
            Console.WriteLine("Mostrando o ultimo valor.\n");

            Console.WriteLine(lista.Last());

            Console.WriteLine("Pressione qualquer botao para voltar ao menu");
            Console.ReadKey();
        }

        public static void RemoverPrimeiro(List<int> lista)
        {
            Console.Clear();
            Console.WriteLine("Removendo o primeiro valor.\n");

            lista.RemoveAt(0);

            Console.WriteLine("Pressione qualquer botao para voltar ao menu");
            Console.ReadKey();
        }

        public static void RemoverUltimo(List<int> lista)
        {
            Console.Clear();
            Console.WriteLine("Mostrando o último valor.\n");

            lista.Remove(lista.Last());

            Console.WriteLine("Pressione qualquer botao para voltar ao menu");
            Console.ReadKey();
        }

        public static void MostrarPares(List<int> lista)
        {
            Console.Clear();
            Console.WriteLine("Mostrando os valores pares.\n");

            var listaPar = lista.Where(x => x % 2 == 0).ToList();
            listaPar.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Pressione qualquer botao para voltar ao menu");
            Console.ReadKey();
        }

        public static void PesquisarNaLista(List<int> lista)
        {
            Console.Clear();
            Console.WriteLine("Digite um valor para pesquisar na lista: ");

            var pesquisa = int.Parse(Console.ReadLine());

            var resultado = lista.FirstOrDefault(x => x == pesquisa);

            if (resultado == 0)
            {
                Console.WriteLine($"Não foi possivel encontrar o valor: {pesquisa}");
            }
            else
            {
                var posicao = lista.IndexOf(resultado);
                Console.WriteLine($"O valor {resultado} foi encontrado na posicao {posicao}");
            }

            Console.WriteLine("Pressione qualquer botao para voltar ao menu");
            Console.ReadKey();
        }

        public static void MostrarOrdemDecrescente(List<int> lista)
        {
            Console.Clear();
            Console.WriteLine("Mostrando ordem Decrescente\n");
            var listaOrdem = lista.OrderByDescending(x => x).ToList();
            listaOrdem.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Pressione qualquer botao para voltar ao menu");
            Console.ReadKey();
        }

        public static void MostrarOrdemCrescente(List<int> lista)
        {
            Console.Clear();
            Console.WriteLine("Mostrando ordem Crescente\n");
            var listaOrdem = lista.OrderBy(x => x).ToList();
            listaOrdem.ForEach(x => Console.WriteLine(x)); ;

            Console.WriteLine("Pressione qualquer botao para voltar ao menu");
            Console.ReadKey();
        }
    }
}
