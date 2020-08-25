using System;
using System.Collections.Generic;
using System.Linq;

namespace AtividadeConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunoLista = new List<Aluno>();
            int option;
            do
            {
                Console.Clear();
                Console.WriteLine(".::. Alunos e notas .::.\n");
                Console.WriteLine("1- Cadastrar aluno. \n2- Ver aprovados \n0- Sair");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Cadastro(alunoLista);
                        break;
                    case 2:
                        MostrarAprovados(alunoLista);
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida.");
                        break;
                }

            }
            while (option != 0);
        }

        public static void Cadastro(List<Aluno> alunos)
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do aluno:\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a nota do aluno:\n");
            var nota = decimal.Parse(Console.ReadLine());

            alunos.Add(new Aluno { Nome = nome, Nota = nota });
        }

        public static void MostrarAprovados(List<Aluno> alunos)
        {
            Console.Clear();
            Console.WriteLine(".::. Alunos Aprovados .::.\n");
            foreach (var aluno in alunos.Where(x => x.Nota > 7))
            {
                Console.WriteLine($"Nome: {aluno.Nome} - Nota: {aluno.Nota}\n");
            }
            Console.WriteLine("\nAperte qualquer botao para voltar ao menu.\n");
            Console.ReadKey();
        }
    }

    public class Aluno
    {
        public string Nome { get; set; }
        public decimal Nota { get; set; }
    }
}
