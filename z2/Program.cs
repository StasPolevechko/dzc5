/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine() ?? "";
    int result = int.Parse(readInput);
    return result;
}
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int SumNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 !=0)
        sum  = sum + array[i];
    }
        return sum;
}


int length = Prompt("количество элементов в массиве: ");
int min = Prompt("минимальное значение массива: ");
int max = Prompt("максимальное значение массива: ");
int[] array = GenerateArray(length, min, max );
int sum = SumNumbers(array);
System.Console.WriteLine($"[{string.Join(",", array)}] -> {sum} ");