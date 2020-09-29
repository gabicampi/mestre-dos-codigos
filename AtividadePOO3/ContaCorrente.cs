using System;

namespace AtividadePOO3
{
    public class ContaCorrente : ContaBancaria
    {
        private decimal TaxaDeOperacao { get; set; }

        public ContaCorrente(decimal taxaDeOperacao, decimal saldo)
        {
            var random = new Random();
            NumeroConta = random.Next();
            Saldo = saldo;
            TaxaDeOperacao = taxaDeOperacao;
        }

        public override void Depositar(double valor)
        {
            if ((decimal)valor > TaxaDeOperacao)
            {
                Console.WriteLine($" Depositando valor: R$ {valor} \n");
                Saldo += (decimal)valor;
                Console.WriteLine($" Aplicando Taxa de Operação: R$ {TaxaDeOperacao} \n");
                Saldo -= TaxaDeOperacao;
                Console.WriteLine($" Saldo atual: R$ {Saldo} \n");
            }
            else
            {
                Console.WriteLine($" Não foi possivel realizar o depósito de: R$ {valor}. Valor abaixo da Taxa de Operação. Saldo negativo não permitido.\n");
            }
        }

        public override void Sacar(double valor)
        {
            if ((decimal)valor <= Saldo - TaxaDeOperacao)
            {
                Console.WriteLine($" Sacando valor: R$ {valor} \n");
                Saldo -= (decimal)valor;
                Console.WriteLine($" Aplicando Taxa de Operação: R$ {TaxaDeOperacao} \n");
                Saldo -= TaxaDeOperacao;
                Console.WriteLine($" Saldo atual: R$ {Saldo} \n");
            }
            else
            {
                Console.WriteLine($" Não foi possivel realizar o saque de: R$ {valor}. Valores abaixo da Taxa de Operação. Saldo negativo não permitido.\n");
            }
        }

        public override void MostrarDados()
        {
            Console.WriteLine($" Tipo de conta: Conta Corrente\n");
            Console.WriteLine($" Numero da Conta: {NumeroConta}\n");
            Console.WriteLine($" Saldo: R$ {Saldo}\n");
            Console.WriteLine($" Taxa de operação: R$ {TaxaDeOperacao}\n");
        }

        public override decimal GetSaldo()
        {
            return Saldo;
        }
    }
}
