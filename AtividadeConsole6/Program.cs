using System;

namespace AtividadeConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".::. REF e OUT .::.\n");
            Console.WriteLine("Leia os comentários no código para esta atividade\n");

            //Ref e Out servem para passar um argumento como referência
            //Passar por referência significa que o objeto sofrerá qualquer alteração realizada dentro do método

            //Diferenças entre eles:

            //O método com Ref necessita que o argumento seja inicializado antes de ser passado como parâmetro

            int exemploInicializado = 0;

            MetodoComRef(ref exemploInicializado);

            MetodoComOut(out exemploInicializado);

            //O método com Out não necessita que o argumento seja inicializado antes de ser passado como parâmetro
            int exemploNaoInicializado1;

            MetodoComOut(out exemploNaoInicializado1);

            MetodoComRef(ref exemploNaoInicializado1);
        }

        public static void MetodoComOut(out int variavel)
        {
            //Apesar de não ser inicializado, é obrigatório inicializar dentro do método.
            //Isso faz com que a informação tenha apenas um sentido, de dentro do método Out para fora
            variavel = 12;
            Console.WriteLine(variavel);
        }

        public static void MetodoComRef(ref int variavel)
        {
            //O Método com Ref, ao receber um parâmetro inicializado pode apenas utilizar de sua informação ou alterar caso deseje
            //Isso faz com que informação tenha 2 sentidos, de fora para dentro e de dentro para fora do método com Ref
            Console.WriteLine(variavel);
        }


        //Exemplos de casos que não são compilados devido as definições de Ref e Out

        //Utilizar Ref sem inicializar
        /*
        
        int exemploNaoInicializado1;

        MetodoComRef(ref exemploNaoInicializado1);

        */

        //Declarar Método Out sem inicializar
        /*
        
        public static void MetodoComOut(out int variavel)
        {
            Console.WriteLine(variavel);
        }

        */
    }
}
