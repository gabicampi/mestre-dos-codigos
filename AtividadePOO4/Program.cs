using System;

namespace AtividadePOO4
{
    class Program
    {
        static void Main(string[] args)
        {
            var controle = new ControleRemoto(new Televisao());

            int opt;
            do
            {
                Console.Clear();
                Console.WriteLine(".::. Controle Remoto .::.\n");
                Console.WriteLine("1- INFO\n" +
                    "2- VOLUME + \n" +
                    "3- VOLUME - \n" +
                    "4- CANAL + \n" +
                    "5- CANAL - \n" +
                    "6- Nº CANAL \n" +
                    "0- Sair");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        controle.MostrarInfo();
                        break;
                    case 2:
                        controle.AumentaVolume();
                        break;
                    case 3:
                        controle.AbaixaVolume();
                        break;
                    case 4:
                        controle.AumentaCanal();
                        break;
                    case 5:
                        controle.AbaixaCanal();
                        break;
                    case 6:
                        controle.DiretoCanal();
                        break;
                    default:
                        break;
                }
            } while (opt != 0);
        }
    }
}
