using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AtividadePOO3.Tests
{
    [TestClass]
    public class ContaEspecialTest
    {
        [TestMethod]
        public void DeveDepositarCorretamente()
        {
            ContaBancaria conta = new ContaEspecial(100, 100);

            conta.Depositar(100);

            Assert.IsTrue(conta.GetSaldo() == 200);
        }

        [TestMethod]
        public void DeveSacarCorretamente()
        {
            ContaBancaria conta = new ContaEspecial(100, 100);

            conta.Sacar(50);

            Assert.IsTrue(conta.GetSaldo() == 50);
        }

        [TestMethod]
        public void DeveSacarValorCredito()
        {
            ContaBancaria conta = new ContaEspecial(100, 100);

            conta.Sacar(150);

            Assert.IsTrue(conta.GetSaldo() == -50m);
        }

        [TestMethod]
        public void NaoDeveSacarValorMaiorQueCredito()
        {
            ContaBancaria conta = new ContaEspecial(100, 100);

            conta.Sacar(250);

            Assert.IsTrue(conta.GetSaldo() == 100m);
        }
    }
}
