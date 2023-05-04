using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        DateTime data;

        CultureInfo cultureBR = new CultureInfo("pt-BR");

        DateTime aniversario = new DateTime(1990, 03, 08);

        Console.WriteLine("Digite uma data:  (dia/mês/ano)" );

        data = DateTime.Parse(Console.ReadLine());

        string dataFormatada = data.ToString("G", cultureBR);


        int compare = DateTime.Compare(aniversario,data);

        if(aniversario == data)
        {
            Console.WriteLine(" É a data do seu aniversário");
        }
        else
        {

            Console.WriteLine(" Não é a data do seu aniversário");
        }

    }
}
