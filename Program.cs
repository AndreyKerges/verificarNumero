int num;
Console.WriteLine("--- Verificar Número ---");

Console.WriteLine("Digite um número: ");
num = Convert.ToInt32(Console.ReadLine());

if (num == 5)
{
    Console.WriteLine("O número é igual a 5");
}
else if (num == 200)
{
    Console.WriteLine("O número é igual a 200");
}
else if (num == 400)
{
    Console.WriteLine("O número é igual a 400");
}
else if (num >= 500 && num <=1000)
{
    Console.WriteLine("O número esta entre o intervalo de 500 e 1000");
}
else
{
    Console.WriteLine("O número não esta nos intervalos anteriores");
}
