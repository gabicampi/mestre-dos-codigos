using System;

namespace AtividadeConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".::. Bhaskara .::.\n");
            Console.WriteLine("aX² + bX + c\n\n");
            Console.WriteLine("Digite o valor para a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor para b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor para c: ");
            int c = int.Parse(Console.ReadLine());

            var delta = b * b - 4 * a * c;
            var R1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var R2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"R1: {R1}\n");
            Console.WriteLine($"R2: {R2}\n");

            Console.ReadKey();
        }
    }
}
