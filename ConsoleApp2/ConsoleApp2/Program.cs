int[] vetor = new int[15];

for (int i = 0; i < 15; i++)
{
    Console.Write("Digite um número: ");
    vetor[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Números positivos:");
for (int i = 0; i < 15; i++)
{
    if (vetor[i] > 0)
        Console.WriteLine(vetor[i]);
}