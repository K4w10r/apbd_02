// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

static double GetAverage(int[] numbers)
{
    double suma = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        suma += numbers[i];
    }

    return suma / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4 };
double average = GetAverage(numbers);
Console.WriteLine(average);