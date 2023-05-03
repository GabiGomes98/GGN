
using System;
using System.Globalization;

namespace informeDia;
class Program
{
    static void Main(string[] args)
    {
        DateTime data = new DateTime(1990,08,03);
   
        CultureInfo cultureBr = new CultureInfo("pt-BR");

        string dataFormatada = data.ToString("G", cultureBr);

        Console.WriteLine(dataFormatada.ToString());
        Console.WriteLine(data.ToString("dd"));




    }
}