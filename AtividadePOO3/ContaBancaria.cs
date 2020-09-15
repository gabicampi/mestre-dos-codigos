using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePOO3
{
    public abstract class ContaBancaria : Imprimivel
    {
        protected int NumeroConta { get; set; }
        protected decimal Saldo { get; set; }
        public abstract void Sacar(double valor);
        public abstract void Depositar(double valor);
        public abstract void MostrarDados();
        public abstract decimal GetSaldo();
    }
}
