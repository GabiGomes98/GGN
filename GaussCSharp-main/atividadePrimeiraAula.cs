using System.Data;
using System.Diagnostics.SymbolStore;

double valor = 3.14d;
Console.WriteLine(valor);

float valorFloat = 3.45f;
Console.WriteLine(valorFloat);

decimal valorDecimal = 1.2m;
Console.WriteLine(valorDecimal);

string nome = "Denise";
Console.WriteLine(nome);

char letra = 'D';
Console.WriteLine(letra);

bool valorBool = false;
Console.WriteLine(valorBool);

DateTime valorNascimento = new DateTime(1990,08,03);
Console.WriteLine(valorNascimento);

//// Ler dois valores e somar

float resultado;
float num = 2f;
float num1= 3.2f;

resultado = num  + num1;
Console.WriteLine(resultado);

//// verificar se é par ou ímpar

Console.WriteLine("Escreva um número: ");
int num2 = Int32.Parse(Console.ReadLine());

if (num2 % 2 == 0)
{
  Console.WriteLine("O número  "+ num2+" é par");
}
else
  {
    Console.WriteLine("O número  "+ num2 + " é ímpar");
}
Console.WriteLine();


// velocidade média

Console.WriteLine("Escreva a distancia percorrida:  em km");

float distancia = float.Parse(Console.ReadLine());

Console.WriteLine("Escreva o tempo gasto:  horas");

float tempo = float.Parse(Console.ReadLine());

resultado = distancia / tempo;

Console.WriteLine(resultado+ "km/h");
