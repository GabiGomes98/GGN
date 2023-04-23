
 
using System.Data;
using System.Diagnostics.SymbolStore;

Console.WriteLine(" Digite o seu peso: ");

float peso = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura:  com (.) ex : 1.62");

float altura = float.Parse(Console.ReadLine());
float alturaAoQuadrado = altura * altura;
float imc = peso / alturaAoQuadrado;

if (imc < 18.5)
{
    Console.WriteLine("O IMC está abaixo do peso e o imc é : " + imc);
}
else if (imc > 18.6 && imc < 24.9)
{

    Console.WriteLine(" Peso ideal e o imc é : " + imc);
}
else if (imc > 25 && imc < 29.9)
{

    Console.WriteLine("Acima do peso e o imc é : " + imc);
}
else

{
    Console.WriteLine("Obesidade e o imc é : " + imc);
}
