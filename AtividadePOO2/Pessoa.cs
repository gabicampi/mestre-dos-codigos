using System;

namespace AtividadePOO2
{
    public class Pessoa
    {
        private string Nome;
        private DateTime DataNascimento;
        private decimal Altura;

        public Pessoa(string nome, DateTime dataNascimento, decimal altura)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetDataNascimento(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
        }

        public void SetAltura(decimal altura)
        {
            Altura = altura;
        }

        public string GetNome()
        {
            return Nome;
        }

        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }

        public decimal GetAltura()
        {
            return Altura;
        }

        public int CalcularIdade()
        {
            var dataHoje = DateTime.Now;
            int idade = dataHoje.Year - DataNascimento.Year;
            if (!FezAniversarioEsteAno())
            {
                idade--;
            }
            return idade;
        }

        private bool FezAniversarioEsteAno()
        {
            var dataHoje = DateTime.Now;

            return (dataHoje.Month > DataNascimento.Month) || (dataHoje.Month == DataNascimento.Month && dataHoje.Day >= DataNascimento.Day);
        }

        public void MostrarDadosPessoais()
        {
            Console.WriteLine($" Nome: {Nome} \n"
                + $" Data de Nascimento: {DataNascimento.ToShortDateString()} \n"
                + $" Altura: {Altura} m \n");
        }
    }
}
