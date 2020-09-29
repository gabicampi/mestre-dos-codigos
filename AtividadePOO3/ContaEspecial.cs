using System;

namespace AtividadePOO3
{
    public class ContaEspecial : ContaBancaria
    {
        private decimal Credito { get; set; }

        public ContaEspecial(decimal credito, decimal saldo)
        {
            var random = new Random();
            NumeroConta = random.Next();
            Credito = credito;
            Saldo = saldo;
        }

        public override void Depositar(double valor)
        {
            Console.WriteLine($" Depositando valor: R$ {valor}\n");
            Saldo += (decimal)valor;
            Console.WriteLine($" Saldo Atual: R$ {Saldo}\n");
        }

        public override void Sacar(double valor)
        {
            if (Saldo + Credito >= (decimal)valor)
            {
                Console.WriteLine($" Sacando valor: R$ {valor}\n");
                Saldo -= (decimal)valor;
                Console.WriteLine($" Saldo Atual: R$ {Saldo}\n");
            }
            else
            {
                Console.WriteLine($" Saldo insuficiente para sacar o valor R$ {valor}\n");
            }
        }

        public override void MostrarDados()
        {
            Console.WriteLine($" Tipo de conta: Conta Especial\n");
            Console.WriteLine($" Numero da Conta: {NumeroConta}\n");
            Console.WriteLine($" Saldo: R$ {Saldo}\n");
            Console.WriteLine($" Credito: R$ {Credito}\n");
        }

        public override decimal GetSaldo()
        {
            return Saldo;
        }
    }
}
