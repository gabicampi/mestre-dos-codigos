using System;

namespace AtividadePOO2
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private DateTime DataNascimento { get; set; }
        private decimal Altura { get; set; }

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
            var DataHoje = DateTime.Now;
            int idade = DataHoje.Year - DataNascimento.Year;
            if (!FezAniversarioEsteAno())
            {
                idade--;
            }
            return idade;
        }

        private bool FezAniversarioEsteAno()
        {
            var DataHoje = DateTime.Now;

            return (DataHoje.Month > DataNascimento.Month) || (DataHoje.Month == DataNascimento.Month && DataHoje.Day >= DataNascimento.Day);
        }

        public void MostrarDadosPessoais()
        {
            Console.WriteLine($" Nome: {Nome} \n" 
                + $" Data de Nascimento: {DataNascimento.ToShortDateString()} \n" 
                + $" Altura: {Altura} m \n");
        }
    }
}
