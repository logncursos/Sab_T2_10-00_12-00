// Desafio: Par ou Ímpar
// O objetivo deste desafio é criar um programa que permite 
// que o usuário insira um número inteiro e, em seguida, determine 
// se o número é par ou ímpar. Use instruções if-else para fazer essa 
//verificação.
// Requisitos:
// 	• Solicite ao usuário que insira um número inteiro.
// 	• Verifique se o número é par ou ímpar.
// 	• Exiba uma mensagem informando se o número é par ou ímpar.

// int numeroDigitado = Convert.ToInt32(Console.ReadLine());
// int resto = numeroDigitado % 2;
// int resto = numeroDigitado - 2 * (numeroDigitado/ 2);
// if(resto == 0){
//     Console.WriteLine("par");
// } else {
//     Console.WriteLine("impar");
// }

Console.WriteLine("Tabuada do?");
int tabuadoDo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------");

for (int i = 0; i <= 10; i++)
{
    int resultadoMult = i * tabuadoDo;
    Console.WriteLine(tabuadoDo+" x "+ i + " = " + resultadoMult);
    Console.WriteLine(resultadoMult % 2 == 0 ? "par" : "impar");
}