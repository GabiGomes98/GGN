int num = 10, num1, distancia;

Console.WriteLine(" Digite um valor: ");
num1 = int.Parse(Console.ReadLine());

distancia = num - num1;

Console.WriteLine(distancia);

if (num1 > 10){ 

    distancia = num1 - num;
    Console.WriteLine(" a distancia em módulo é : "+distancia);
}
else
{
    distancia = num - num1;
    Console.WriteLine("A distancia é : ",distancia);

}



