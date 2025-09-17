// OperadoresAritmeticos

/*
    + = Adição
    - = Subtração
    * = Multiplicação
    / = Divisão
*/

int soma = 2 + 2;
int subtração = 10 - 5;
int multiplicação = 3 * 7;
double divisão = 3 / 2.5;

// Utilizando Operadores Aritmeticos com variedades
int num1, num2, resultado;
Console.WriteLine("Insira a primeira Nota");
num1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Insira a segunda Nota");
num2 = Convert.ToInt16(Console.ReadLine());

resultado = num1 + num2;
Console.WriteLine($"A soma das notas é: {resultado}");

