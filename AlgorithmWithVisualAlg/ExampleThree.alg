algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 04/07/2019
// Informar um novo n�mero enquanto ele � for divisivel por 5
var
   numero, resultadoDivisao: inteiro
inicio
      // INICIO ENTRADA
      escreva("Informe um numero: ")
      leia(numero)
      // FIM ENTRADA

      //INICIO PROCESSAMENTO
      resultadoDivisao <- (numero mod 5)
      
      enquanto (resultadoDivisao <> 0) faca
             escreva("Informe um numero: ")
             leia(numero)
             resultadoDivisao <- (numero mod 5)
      fimenquanto
      //FIM PROCESSAMENTO
      
      //INICIO SAIDA
      escreva("Numero div por 5 �: ", numero)
      //FIM SAIDA
      
fimalgoritmo
