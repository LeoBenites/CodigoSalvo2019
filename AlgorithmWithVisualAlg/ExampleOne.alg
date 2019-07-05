algoritmo "MaiorAndMenorNumero"
// Função :
// Autor : Thiago Boccalon
// Data : 04/07/2019
// Objetivo do programa é encontrar o maior número digitado
var
   primeiroNumero, segundoNumero, terceiroNumero , maior, menor: real
inicio
      escreva("Escreva o primeiro numero: ")
      leia(primeiroNumero)

      escreva("Escreva o segundo numero: ")
      leia(segundoNumero)
      
      escreva("Escreva o terceiro numero: ")
      leia(terceiroNumero)
      
      se(primeiroNumero >= segundoNumero) entao
                        se(primeiroNumero >= terceiroNumero) entao
                                          maior <- primeiroNumero
                        senao
                             maior <- segundoNumero
                        fimse
      senao
           se(segundoNumero >= terceiroNumero) entao
                            maior <- segundoNumero
           senao
                maior <- terceiroNumero
           fimse
      fimse
      
      
      escreva("O maior numero: ", maior)
fimalgoritmo
