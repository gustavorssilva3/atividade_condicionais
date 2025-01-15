Console.Write("Digite um número: ");
double numero = double.Parse(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("O número " + numero + " é positivo.");
}
else if (numero < 0)
{
    Console.WriteLine("O número " + numero + " é negativo.");
}
else
{
    Console.WriteLine("O número é zero.");
}