namespace informeAno;
class Program
{
    static void Main(string[] args)
    {
        DateTime data;
        Console.WriteLine("DIGITE UMA DATA: ");
        data = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(data);
        Console.WriteLine(data.ToString("yyyy"));
        
    }
}

