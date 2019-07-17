using System;

namespace ExampleThreeCSharp
{
    public class ExampleCodeThree
    {
        private int numero, resultadoDivisao;

        public void ValidarNumerosDivisiveisPorCinco()
        {
            Console.Write("Informe um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            resultadoDivisao = numero % 5;

            while (resultadoDivisao != 0)
            {
                Console.Write("Informe um numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                resultadoDivisao = numero % 5;
            }

            Console.WriteLine("Numero {0} eh divisivel por 5.", numero);
        }
    }
}
