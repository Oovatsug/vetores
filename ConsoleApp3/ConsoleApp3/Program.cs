Coint[] vetor = new int[8];
bool encontrou = false;

for (int i = 0; i < 8; i++)
{
    Console.Write("Digite um número: ");
    vetor[i] = int.Parse(Console.ReadLine());
}

Console.Write("Digite um valor para buscar: ");
int valor = int.Parse(Console.ReadLine());

for (int i = 0; i < 8; i++)
{
    if (vetor[i] == valor)
    {
        Console.WriteLine("Encontrado na posição: " + i);
        encontrou = true;
    }
}

if (!encontrou)
    Console.WriteLine("O número não se encontra no vetor");