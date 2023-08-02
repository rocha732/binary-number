int numero = 0;
string bin = "";

Console.WriteLine("Escriba un numero para convertirlo a binario");
numero = int.Parse(Console.ReadLine());

while (numero > 0)
{
    bin = numero % 2 + bin; 
    numero = numero / 2;
}

Console.WriteLine(bin);
