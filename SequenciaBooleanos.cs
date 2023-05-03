

using System;
using System.Collections.Generic;


internal class Program
{
    private static bool valores;

    private static void Main(string[] args)
    {
        var valor = new List<bool>();

        int i = 0;
        while (i < 5) {
            //valor.Add(false);
            valor.Add(true);
            foreach (var valores in valor)
                i += 1;
            { 
        Console.WriteLine(valores);
               

             }

        }


    }
}