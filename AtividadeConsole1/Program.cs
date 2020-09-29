using System;

namespace AtividadeConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarEscolhaDeValores();
        }

        public static string EhPar(int valor)
        {
            if (valor % 2 == 0) return "PAR";

            return "IMPAR";
        }

        public static void MostrarValoresComParidade(int valorA, int valorB)
        {
            Console.Clear();
            Console.WriteLine($".::. VALORES DE A E B .::. \n");
            Console.WriteLine($"A : {valorA} ({ EhPar(valorA) }) \n");
            Console.WriteLine($"B : {valorB} ({ EhPar(valorB) }) \n");
            Console.WriteLine($"Aperte qualquer botão para continuar\n");
            Console.ReadKey();
        }

        public static void MostrarSoma(int valorA, int valorB)
        {
            Console.Clear();
            Console.WriteLine($".::. SOMA .::. \n");
            Console.WriteLine($"A + B = {valorA} + {valorB} = { valorA + valorB } \n");
            Console.WriteLine($"Aperte qualquer botão para continuar\n");
            Console.ReadKey();
        }

        public static void MostrarSubtracao(int valorA, int valorB)
        {
            Console.Clear();
            Console.WriteLine($".::. SUBTRACAO .::. \n");
            Console.WriteLine($"A - B = {valorA} - {valorB} = { valorA - valorB } \n");
            Console.WriteLine($"Aperte qualquer botão para continuar\n");
            Console.ReadKey();
        }

        public static void MostrarDivisao(int valorA, int valorB)
        {
            Console.Clear();
            Console.WriteLine($".::. DIVISAO .::. \n");
            Console.WriteLine($"B / A = {valorB} / {valorA} = { valorB / valorA } \n");
            Console.WriteLine($"Aperte qualquer botão para continuar\n");
            Console.ReadKey();
        }

        public static void MostrarMultiplicacao(int valorA, int valorB)
        {
            Console.Clear();
            Console.WriteLine($".::. MULTIPLICACAO .::. \n");
            Console.WriteLine($"A * B = {valorA} * {valorB} = { valorA * valorB } \n");
            Console.WriteLine($"Aperte qualquer botão para continuar\n");
            Console.ReadKey();
        }

        public static void MostrarEscolhaDeValores()
        {
            Console.WriteLine(".::. Cálculos com 2 valores .::.\n");
            Console.WriteLine("Insira o primeiro valor para A: \n");
            var valorA = Console.ReadLine();
            Console.WriteLine("Insira o segundo valor para B: \n");
            var valorB = Console.ReadLine();

            MostrarMenu(int.Parse(valorA), int.Parse(valorB));
        }

        public static void MostrarMenu(int valorA, int valorB)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine(".::. Escolha uma opção .::.\n");
                Console.WriteLine("1- Soma \n2- Subtracao \n3- Divisao \n4- Multiplicacao \n5- Mostrar valores e paridade \n0- Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        return;
                    case 1:
                        MostrarSoma(valorA, valorB);
                        break;
                    case 2:
                        MostrarSubtracao(valorA, valorB);
                        break;
                    case 3:
                        MostrarDivisao(valorA, valorB);
                        break;
                    case 4:
                        MostrarMultiplicacao(valorA, valorB);
                        break;
                    case 5:
                        MostrarValoresComParidade(valorA, valorB);
                        break;
                    default:
                        Console.WriteLine("Insira um valor válido");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
