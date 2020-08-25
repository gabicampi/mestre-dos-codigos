using System;

namespace AtividadePOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..:: Classe Pessoa ::..");

            //Novo Cadastro pessoa
            Pessoa exemplo1 = new Pessoa("Fulano de Tal", new DateTime(1990, 12, 31), 1.80m);

            //Metodos get
            var nomePessoa = exemplo1.GetNome();
            var alturaPessoa = exemplo1.GetAltura();
            var dataNascimentoPessoa = exemplo1.GetDataNascimento();

            //Mostrando dados pessoais
            exemplo1.MostrarDadosPessoais();

            //Metodo calcula idade
            Console.WriteLine($" Idade: {exemplo1.CalcularIdade()} \n");

            //Metodos Set
            exemplo1.SetNome("Ciclano de Tal");
            exemplo1.SetDataNascimento(new DateTime(1990, 1, 15));
            exemplo1.SetAltura(1.77m);

            //Mostrando dados pessoais novamente
            exemplo1.MostrarDadosPessoais();

            //Metodo calcula idade novamente
            Console.WriteLine($" Idade: {exemplo1.CalcularIdade()} \n");

            Console.WriteLine("Pressione qualquer botao para finalizar");
            Console.ReadKey();
        }
    }
}
