using ExampleOneInCSharp;
using ExampleTwoInCSharp;
using ExampleThreeCSharp;
using ExampleFourCSharp;
using ExampleFiveCSharp;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleCodeOne exampleCodeOne = new ExampleCodeOne();
            ExampleCodeTwo exampleCodeTwo = new ExampleCodeTwo();
            ExampleCodeThree exampleCodeThree = new ExampleCodeThree();
            ExampleCodeFour exampleCodeFour = new ExampleCodeFour();
            ExampleCodeFive exampleCodeFive = new ExampleCodeFive();


            exampleCodeOne.InformarMaiorNumeroInserido();
            exampleCodeTwo.InformarMesReferenteAoMesDigitado();
            exampleCodeThree.ValidarNumerosDivisiveisPorCinco();
            exampleCodeFour.EncontrarNumerosPares();
            exampleCodeFive.MainSystem();
        }
    }
}
