Console.Write("Digite o primeiro número: ");
double numero1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double numero2 = double.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("O primeiro número (" + numero1 + ") é maior que o segundo número (" + numero2 + ").");
}
else if (numero2 > numero1)
{
    Console.WriteLine("O segundo número (" + numero2 + ") é maior que o primeiro número (" + numero1 + ").");
}
else
{
    Console.WriteLine("Os dois números são iguais.");
}