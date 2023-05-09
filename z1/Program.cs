/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine() ?? "";
    int result = int.Parse(readInput);
    return result;
}
int[] GenerateArray(int Length)
{
    int[] array = new int[Length];
    Random random = new Random();
        for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(100,1000);
    }
    return array;
}
int QuantityEvenNumbers(int[] array)
{
    int qantitly = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 ==0)
        qantitly = qantitly + 1;
    }
        return qantitly;
}


int length = Prompt("количество элементов в массиве: ");
int[] array = GenerateArray(length );
int qantitly = QuantityEvenNumbers(array);
System.Console.WriteLine($"[{string.Join(",", array)}] -> {qantitly} ");