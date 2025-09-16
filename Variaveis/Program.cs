// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// String para armazenar texto
// para comentario "ctrl + K + C"
string nome = "Kevillyen Thawanny";

// tipo de variavel para valores inteiros: 1, 2 e etc
int idade = 16;

// tipo de variavel para valores decimais: 1.5, 2.5 e etc
float altura = 1.59f; // nao se utiliza para instituiçao financeira ou coisas precisas
double preco = 17.5; 

// tipo de variavel para valores logicos: true or false
bool estudante= true;

// tipo de variavel para valores unicos: 'A', 'B' e etc
char genero= 'M';

// tipo de variavel para valores constantes: PI = 3.14
const double PI = 3.14;

//Forma 1
Console.WriteLine(nome);

//Forma 2 - Interpolação de strings
Console.WriteLine($"A {nome} tem {idade} anos ");

//Forma 3 - Concatenação de strings
Console.WriteLine($"A " + nome + " tem " + idade + " anos ");

// Utilizando \n para pular uma linha 
// Semelhante ao <br> no HTML que ja utilizamos 
Console.WriteLine($"\n O valor de pi é {PI}");


