// Desafio: Par ou Ímpar
// O objetivo deste desafio é criar um programa que permite 
// que o usuário insira um número inteiro e, em seguida, determine 
// se o número é par ou ímpar. Use instruções if-else para fazer essa 
//verificação.
// Requisitos:
// 	• Solicite ao usuário que insira um número inteiro.
// 	• Verifique se o número é par ou ímpar.
// 	• Exiba uma mensagem informando se o número é par ou ímpar.




int numeroDigitado = Convert.ToInt32(Console.ReadLine());
int resto = numeroDigitado / 2;

if(resto == 0){
    Console.WriteLine("par");
} else {
    Console.WriteLine("impar");
}
// int resto = numeroDigitado - 2 * (numeroDigitado/ 2); - Essa e a formula para o resto da divisao de um numero. Para o exercicio de amanha.