using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePOO4
{
    public class ControleRemoto
    {
        private readonly Televisao Televisao;

        public ControleRemoto(Televisao televisao)
        {
            Televisao = televisao;
        }

        public void AumentaVolume()
        {
            Televisao.Volume++;
        }

        public void AbaixaVolume()
        {
            Televisao.Volume--;
        }

        public void AumentaCanal()
        {
            Televisao.Canal++;
        }

        public void AbaixaCanal()
        {
            Televisao.Canal--;
        }

        public void DiretoCanal()
        {
            Console.Clear();
            Televisao.Canal = int.Parse(Console.ReadLine());
        }

        public void MostrarInfo()
        {
            Console.Clear();
            Console.WriteLine($"Volume: {Televisao.Volume} Canal: {Televisao.Canal} \n");
            Console.ReadKey();
        }
    }
}
