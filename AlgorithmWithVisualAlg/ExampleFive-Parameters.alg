algoritmo "PassagemParametros"
// Função :
// Autor :
// Data : 17/07/2019
// Seção de Declarações 
var
   nota: real
   somaDasNotas : real
   totalAlunos : inteiro
   opcao : inteiro

   procedimento media (notas, nNotas: real)
   var media : real
   inicio
       media <- notas / nNotas
       retorne media
   fimprocedimento
   
   funcao cadastrarNotaDoAluno : real
   inicio
         escreva("Informe a Nota do Aluno: ")
         leia(nota)
         retorne nota
   fimfuncao
   
   funcao somarNotaDosAlunos (nota : real) : real
   inicio
         somaDasNotas <- somaDasNotas + nota
   fimfuncao
   
inicio
      escreval("##### MENU ######")
      
      escreval("1 - Cadastrar Nota do Aluno")
      escreval("99 - Sair")
      escreva("Opção: ")
      leia(opcao)

      enquanto opcao <> 99 faca
             nota <- cadastrarNotaDoAluno
             somarNotaDosAlunos(nota)
             totalAlunos <- totalAlunos + 1
      fimenquanto
      
      escreva("A média dos Alunos é: ",  media(somaDasNotas, totalAlunos)
      
fimalgoritmo
