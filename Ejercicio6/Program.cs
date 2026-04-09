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

double[] numeros = new double[TArreglo];

for (int i = 0; i < numeros.Length; i++)
{
    bool numeroValido = false;
    do
    {
        Console.Write($"Ingrese el número {i + 1}: ");
        if (!double.TryParse(Console.ReadLine(), out numeros[i]))
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

double MenorNumero = numeros[0];

for (int j = 1; j < numeros.Length; j++)
{
    if (numeros[j] < MenorNumero)
    {
        MenorNumero = numeros[j];
    }
}
Console.WriteLine($"El menor número es: {MenorNumero}");