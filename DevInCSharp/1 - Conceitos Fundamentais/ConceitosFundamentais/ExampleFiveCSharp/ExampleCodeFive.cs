using System;

namespace ExampleFiveCSharp
{
    public class ExampleCodeFive
    {
        private double somaDasNotas, nota;


        public void MainSystem()
        {
            int opcao;
            int totalAlunos = 0;

            Console.WriteLine("#### MENU ####");
            Console.WriteLine("0 - Cadastrar Nota do Aluno");
            Console.WriteLine("99 - Sair");

            Console.Write("Opcao: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            while(opcao != 99)
            {
                nota = CadastrarNotaDoAluno();
                SomarNotaDosAlunos(nota);
                totalAlunos += 1;

                Console.WriteLine("#### MENU ####");
                Console.WriteLine("0 - Cadastrar Nota do Aluno");
                Console.WriteLine("99 - Sair");

                Console.Write("Opcao: ");
                opcao = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("A media dos alunos eh: {0}", CalcularMedia(somaDasNotas, totalAlunos));
        }

        private void SomarNotaDosAlunos(double nota)
        {
            somaDasNotas = +nota;
        }

        private double CadastrarNotaDoAluno()
        {
            Console.Write("Informe a nota do Aluno: ");
            nota = Convert.ToInt32(Console.ReadLine());
            return nota;
        }

        private double CalcularMedia(double notas, double nNotas)
        {
            double media;
            media = notas / nNotas;
            return media;
        }
    }
}
