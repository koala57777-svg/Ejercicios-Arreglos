int TArreglo;

do
{
    Console.Write("Ingrese el tamaño del arreglo: ");

    if (!int.TryParse(Console.ReadLine(), out TArreglo) || TArreglo <= 0)
    {
        Console.WriteLine();
        Console.WriteLine("Tamaño inválido");
        TArreglo = -1;
        Console.WriteLine();
    }
} while (TArreglo <= 0);
Console.WriteLine();

int[] numeros = new int[TArreglo];

for (int i = 0; i < numeros.Length; i++)
{
    bool numeroValido = false;
    do
    {
        Console.Write($"Ingrese el número {i + 1}: ");
        if (!int.TryParse(Console.ReadLine(), out numeros[i]))
        {
            Console.WriteLine();
            Console.WriteLine("Número inválido");
            Console.WriteLine();
        }
        else
        {
            numeroValido = true;
        }
    } while (!numeroValido);
    Console.WriteLine();
}
Console.WriteLine("Presione cualquier tecla para mostrar el resultado...");
Console.ReadKey();
Console.Clear();

Console.WriteLine("Pares");
Console.WriteLine();

for (int j = 0; j < numeros.Length; j++)
{
    if (numeros[j] % 2 == 0)
    {
                Console.WriteLine(numeros[j]);
        Console.WriteLine();
    }
}
for (int j = 1; j <= 13; j++)
{
    Console.Write("-");
}
Console.WriteLine();
Console.WriteLine("Impares");
Console.WriteLine();

for (int j = 0; j < numeros.Length; j++)
{
    if (numeros[j] % 2 != 0)
    {
        Console.WriteLine(numeros[j]);
        Console.WriteLine();
    }
}
