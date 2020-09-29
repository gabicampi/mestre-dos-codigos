using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AtividadePOO3.Tests
{
    [TestClass]
    public class ContaCorrenteTest
    {
        [TestMethod]
        public void DeveAplicarTaxaDeOperacaoAoDepositar()
        {
            ContaBancaria conta = new ContaCorrente(1, 100);

            conta.Depositar(10);

            Assert.IsTrue(conta.GetSaldo() == 109m);
        }

        [TestMethod]
        public void DeveAplicarTaxaDeOperacaoAoSacar()
        {
            ContaBancaria conta = new ContaCorrente(1, 100);

            conta.Sacar(10);

            Assert.IsTrue(conta.GetSaldo() == 89m);
        }

        [TestMethod]
        public void NaoDeveRealizarOperacaoDepositarComValorBaixo()
        {
            ContaBancaria conta = new ContaCorrente(10, 100);

            conta.Depositar(1);

            Assert.IsTrue(conta.GetSaldo() == 100m);
        }

        [TestMethod]
        public void NaoDeveRealizarOperacaoSacarComValorBaixo()
        {
            ContaBancaria conta = new ContaCorrente(1, 100);

            conta.Sacar(100);

            Assert.IsTrue(conta.GetSaldo() == 100m);
        }
    }
}
