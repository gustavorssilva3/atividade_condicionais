Console.Write("Digite a idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 16)
{
    Console.WriteLine("Você pode votar.");
}
else
{
    Console.WriteLine("Você não pode votar.");
}