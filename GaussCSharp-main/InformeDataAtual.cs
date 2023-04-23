using System;
 namespace informeDiaAtual;

class program
{
    static void Main (string[] args)
    {
        DateTime data = DateTime.Now;

        Console.WriteLine(data.ToString("dd/MM/yyyy"));
    }
}

