namespace ContagemCaracter;
class Program
{
    static void Main(string[] args)
    {
        DateTime data;
       
        DateTime aniversario = new DateTime(1990, 03, 08);
        
        Console.WriteLine("Digite uma data:  (dia/mês/ano)" );
        data = DateTime.Parse(Console.ReadLine());
        

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
