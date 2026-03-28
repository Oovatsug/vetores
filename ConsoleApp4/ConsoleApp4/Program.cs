int[] v1 = new int[10];
int[] v2 = new int[10];
int[] v3 = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write("Vetor 1 - Digite um número: ");
    v1[i] = int.Parse(Console.ReadLine());

    Console.Write("Vetor 2 - Digite um número: ");
    v2[i] = int.Parse(Console.ReadLine());

    v3[i] = v1[i] + v2[i];
}

Console.WriteLine("Vetor resultante:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(v3[i]);
}