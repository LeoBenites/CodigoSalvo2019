using System;

namespace ExampleOneInCSharp
{
    public class ExampleCodeOne
    {
        private double primeiroNumero, segundoNumero, terceiroNumero;
        private double maior;

        public void InformarMaiorNumeroInserido()
        {
            InserirNumeros();
            EncontrarMaiorNumero();
        }

        private double EncontrarMaiorNumero()
        {
            if(primeiroNumero >= segundoNumero)
            {
                if (primeiroNumero >= terceiroNumero)
                    maior = primeiroNumero;
                else
                    maior = segundoNumero;
            }
            else
            {
                if (segundoNumero >= terceiroNumero)
                    maior = primeiroNumero;
                else
                    maior = segundoNumero;
            }

            return maior;
        }

        private void InserirNumeros()
        {
            Console.Write("Informe o primeiro numero: ");
            primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o segundo numero: ");
            segundoNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o terceiro numero: ");
            terceiroNumero = Convert.ToDouble(Console.ReadLine());
        }

    }
}
