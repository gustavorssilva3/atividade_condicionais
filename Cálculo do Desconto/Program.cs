Console.Write("Digite o valor da compra: ");
double valorCompra = double.Parse(Console.ReadLine());

if (valorCompra > 100)
{
    double valorFinal = valorCompra * 0.90;
    Console.WriteLine("Valor com desconto: " + valorFinal);
}
else
{
    Console.WriteLine("Valor original: " + valorCompra);
}