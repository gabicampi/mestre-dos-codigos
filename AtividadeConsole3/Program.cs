using System;

namespace AtividadeConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            int contagem = 1;
            while (contagem <= 100)
            {
                if (contagem % 3 == 0)
                {
                    Console.WriteLine($"{contagem}\n");
                }
                contagem++;
            }
            Console.WriteLine("\nAperte qualquer botao para finalizar\n");
            Console.ReadKey();
        }
    }
}
