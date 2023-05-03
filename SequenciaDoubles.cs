using System;
using System.Collections.Generic;

internal class Program
{

    private static double sequencia;

    private static void Main(string[] args)
    {
        var valor = new List<double>() { 1.3, 1.5, 3.5, 3.6, 5.5 };

        foreach (var sequencia in valor)
        {
            Console.WriteLine(sequencia);

        }
    }
}