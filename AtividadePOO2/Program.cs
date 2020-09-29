using System;

namespace AtividadePOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..:: Classe Pessoa ::..");

            //Novo Cadastro pessoa
            Pessoa exemplo = new Pessoa("Fulano de Tal", new DateTime(1990, 12, 31), 1.80m);

            //Metodos get
            var nomePessoa = exemplo.GetNome();
            var alturaPessoa = exemplo.GetAltura();
            var dataNascimentoPessoa = exemplo.GetDataNascimento();

            //Mostrando dados pessoais
            exemplo.MostrarDadosPessoais();

            //Metodo calcula idade
            Console.WriteLine($" Idade: {exemplo.CalcularIdade()} \n");

            //Metodos Set
            exemplo.SetNome("Ciclano de Tal");
            exemplo.SetDataNascimento(new DateTime(1990, 1, 15));
            exemplo.SetAltura(1.77m);

            //Mostrando dados pessoais novamente
            exemplo.MostrarDadosPessoais();

            //Metodo calcula idade novamente
            Console.WriteLine($" Idade: {exemplo.CalcularIdade()} \n");

            Console.WriteLine("Pressione qualquer botao para finalizar");
            Console.ReadKey();
        }
    }
}
