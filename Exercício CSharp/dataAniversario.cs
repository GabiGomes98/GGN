using System;

namespace ContagemCaracter;
class Program
{
    static void Main(string[] args)
    {
        DateTime dtdata = DateTime.Now;
        DateTime aniversario = new DateTime(1998, 02, 21);


        Console.WriteLine(dtdata.ToString("dd/MM/yyyy"));

        if (aniversario == dtdata)
        {
            Console.WriteLine("A data informada é seu aniversário.");
        }
        else
        {
            Console.WriteLine("Não é seu aniversário!");
        }
        


    }
}

