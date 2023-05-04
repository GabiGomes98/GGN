namespace carro;
class Program
{
    static void Main(string[] args)
    {

        var carro = new Carro();

        carro.modelo = "Gol";
        carro.ano = 2000;
        carro.km = 50.3f;

        var carro1 = new Carro();

        carro1.modelo = "Uno";
        carro1.ano = 2015;
        carro1.km = 25.6f;

        var motor = new Motor();

        motor.modelo = "V8";
        motor.tipo = "xyz";
        motor.tamanho = 10;

        Console.WriteLine("O Carro  " + carro.modelo + " ano:  " + carro.ano + "  com a quantidade em km:  " + carro.km);
        Console.WriteLine("O Carro  " + carro1.modelo + " ano:  " + carro1.ano + " com a quantidade em km:  " + carro1.km);
        Console.WriteLine("O motor:  " + motor.tipo + " é do tipo  " + motor.tipo + " e do tamanho  " + motor.tamanho);
    }
}

