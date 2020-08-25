using System;

namespace AtividadePOO3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cc = new ContaCorrente(5, 100);
            ContaBancaria ce = new ContaEspecial(70, 100);
            int opt;
            do
            {
                Console.Clear();
                Console.WriteLine(".::. Contas bancárias .::.\n");
                Console.WriteLine("1- Mostrar dados da conta corrente \n" +
                    "2- Mostrar dados da conta especial \n" +
                    "3- Depositar na conta corrente \n" +
                    "4- Depositar na conta especial \n" +
                    "5- Sacar na conta corrente \n" +
                    "6- Sacar na conta especial \n" +
                    "0- Sair");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        MostrarDados(cc);
                        break;
                    case 2:
                        MostrarDados(ce);
                        break;
                    case 3:
                        Depositar(cc);
                        break;
                    case 4:
                        Depositar(ce);
                        break;
                    case 5:
                        Sacar(cc);
                        break;
                    case 6:
                        Sacar(ce);
                        break;
                    default:
                        break;
                }
            } while (opt != 0);
        }

        private static void Sacar(ContaBancaria cb)
        {
            Console.Clear();
            Console.WriteLine("Digite valor para sacar: ");
            var valor = Console.ReadLine();
            cb.Sacar(double.Parse(valor));

            Console.WriteLine("\nPressione qualquer botao para voltar ao menu\n");
            Console.ReadKey();
        }

        private static void Depositar(ContaBancaria cb)
        {
            Console.Clear();
            Console.WriteLine("Digite valor para depositar: ");
            var valor = Console.ReadLine();
            cb.Depositar(double.Parse(valor));

            Console.WriteLine("\nPressione qualquer botao para voltar ao menu\n");
            Console.ReadKey();
        }

        private static void MostrarDados(ContaBancaria cb)
        {
            Console.Clear();
            cb.MostrarDados();

            Console.WriteLine("\nPressione qualquer botao para voltar ao menu\n");
            Console.ReadKey();
        }
    }
}
