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

double NumeroBuscar;
bool BuscarValida = false;

do
{
    BuscarValida = false;

    Console.Write("Ingrese el número a buscar: ");

    if (!double.TryParse(Console.ReadLine(), out NumeroBuscar))
    {
        Console.WriteLine();
        Console.WriteLine("Número inválido");
        Console.WriteLine();
    }
    else
    {
        BuscarValida = true;
    }
} while (!BuscarValida);
Console.WriteLine();

int ContadorRepeticiones = 0;

for (int j = 0; j < numeros.Length; j++)
{
    if (numeros[j] == NumeroBuscar)
    {
        ContadorRepeticiones++;
    }
}

Console.WriteLine($"El número {NumeroBuscar} se repite {ContadorRepeticiones} veces en la lista.");
