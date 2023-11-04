// Desafio: Calculadora Simples
// 
// Crie um programa em C# que funcione como uma calculadora simples. O programa deve pedir ao usuário que insira dois números e uma operação (adição, subtração, multiplicação ou divisão). Em seguida, ele deve calcular o resultado com base na operação inserida e exibir o resultado.
// ------------------------------------------
// Regras:
// Solicite ao usuário que insira o primeiro número, a operação (utilize "+", "-", "*", ou "/") e o segundo número.
// Use uma estrutura if e else para determinar qual operação o usuário deseja realizar.
// Realize a operação correspondente e exiba o resultado.
// ------------------------------------------
// Exemplo de saída:
// Digite o primeiro número: 10
// Digite a operação (+, -, *, /): *
// Digite o segundo número: 5
// Resultado: 50
// ------------------------------------------
// Dica:
// Você pode usar as operações matemáticas +, -, * e / para calcular o resultado com base na operação inserida pelo usuário. Certifique-se de tratar casos em que a operação pode ser inválida (por exemplo, divisão por zero).

Console.WriteLine("Digite um numero");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um opeardor -, +, *, /, ");
string operador = Console.ReadLine();

Console.WriteLine("Digite outro numero");
int numero2 = Convert.ToInt32(Console.ReadLine());

if(operador == "*"){
    int resultado = numero1 * numero2;
    Console.WriteLine(resultado);
} 
if(operador == "/"){
    int resultado = numero1 / numero2;
    Console.WriteLine(resultado);
}