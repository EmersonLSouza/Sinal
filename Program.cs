int numero;

Console.Write("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("Voce digitou um numero positivo!");
}

else if (numero < 0)
{
    Console.WriteLine("Voce digitou um número negativo!");
}
else
{
    Console.WriteLine("Voce digitou o número zero!");
}