double[] salarios = new double[10];

for (int i = 0; i < 10; i++)
{
    Console.Write("Digite o salário: ");
    salarios[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    salarios[i] = salarios[i] * 1.05;
}

Console.WriteLine("Salários reajustados:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(salarios[i]);
}