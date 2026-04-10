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

for (int j = 0; j < numeros.Length; j++)
{
    Console.WriteLine($"Número {j + 1}: {numeros[j]}");
    Console.WriteLine();
}

Console.WriteLine("Presione cualquier tecla para mostrar el resultado...");
Console.ReadKey();
Console.Clear();

int Posicion;
bool Validar = false;

do
{
    Validar = false;

    Console.Write("Ingrese una posición de la lista: ");

    if (!int.TryParse(Console.ReadLine(), out Posicion) || Posicion<=0 || Posicion>(numeros.Length))
    {
        Console.WriteLine();
        Console.WriteLine("Posición de lista inválida");
        Console.WriteLine();
    }
    else
    {
        Validar = true;
    }
} while (!Validar);
Console.WriteLine();

double NumeroReemplazar;

do
{
    Validar = false;

    Console.Write("Ingrese el número para reemplazar: ");

    if (!double.TryParse(Console.ReadLine(), out NumeroReemplazar))
    {
        Console.WriteLine();
        Console.WriteLine("Número inválido");
        Console.WriteLine();
    }
    else
    {
        Validar = true;
    }
} while (!Validar);

numeros[Posicion-1] = NumeroReemplazar;

Console.WriteLine();
Console.WriteLine("Número reemplazado correctamente.");
Console.WriteLine();

for (int k = 0; k < numeros.Length; k++)
{
    Console.WriteLine($"Número {k + 1}: {numeros[k]}");
    Console.WriteLine();
}