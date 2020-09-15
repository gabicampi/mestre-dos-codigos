using System;
using Xunit;

namespace AtividadePOO4.Tests
{
    public class ControleRemotoTeste
    {
        [Fact]
        public void DeveIncrementarVolume()
        {
            var televisao = new Televisao();
            var controle = new ControleRemoto(televisao);

            var volumePrev = televisao.Volume;

            controle.AumentaVolume();

            Assert.Equal(volumePrev + 1, televisao.Volume);
        }

        [Fact]
        public void DeveDecrementarVolume()
        {
            var televisao = new Televisao();
            var controle = new ControleRemoto(televisao);

            var volumePrev = televisao.Volume;

            controle.AbaixaVolume();

            Assert.Equal(volumePrev - 1, televisao.Volume);
        }

        [Fact]
        public void DeveIncrementarCanal()
        {
            var televisao = new Televisao();
            var controle = new ControleRemoto(televisao);

            var canalPrev = televisao.Canal;

            controle.AumentaCanal();

            Assert.Equal(canalPrev + 1, televisao.Canal);
        }

        [Fact]
        public void DeveDecrementarCanal()
        {
            var televisao = new Televisao();
            var controle = new ControleRemoto(televisao);

            var canalPrev = televisao.Canal;

            controle.AbaixaCanal();

            Assert.Equal(canalPrev - 1, televisao.Canal);
        }
    }
}
