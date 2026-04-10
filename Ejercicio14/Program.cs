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

double[] Copianumeros = new double[TArreglo];

for (int j = 0; j < numeros.Length; j++)
{
    Copianumeros[j] = numeros[j];
}


Console.WriteLine("Lista ordenada de menor a mayor");

double MenorNumero = Copianumeros[0];
int PosicionMenor = 0;

for (int i=0; i< Copianumeros.Length; i++)
{ 
    MenorNumero = Copianumeros[0];
    PosicionMenor = 0;
    for (int j = 0; j < Copianumeros.Length; j++)
    {
        if (Copianumeros[j] < MenorNumero)
        {
            MenorNumero = Copianumeros[j];
            PosicionMenor = j;
        }
    }
    Console.Write($"{MenorNumero}, ");
    Copianumeros[PosicionMenor] = int.MaxValue;
}
