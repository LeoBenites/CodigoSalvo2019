using System;

namespace ExampleFourCSharp
{
    public class ExampleCodeFour
    {
        private int numeroLimite, numero;

        public void EncontrarNumerosPares()
        {
            Console.Write("Informe o n-essimo numero: ");
            numeroLimite = Convert.ToInt32(Console.ReadLine());

            for(numero = 1; numero <= numeroLimite; numero++)
            {
                if (numero % 2 == 0)
                    Console.WriteLine("{0} eh par.", numero);
            }
        }
    }
}
