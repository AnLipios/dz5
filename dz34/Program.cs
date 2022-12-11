//Задайте массив заполненный случайными 
//положительными трёхзначными числами. 
//Напишите программу, которая покажет 
//количество чётных чисел в массиве.


Console.Clear();
int[] array = PositiveArray(15, 100, 1000);
Console.WriteLine(String.Join(" ", array));

int EvenCount = 0;
for (int i = 0; i<array.Length; i++){
    int u = array[i];
    if (u%2==0)
    EvenCount += 1;

    }

Console.WriteLine($"Количество чётных числел: {EvenCount}");
int[] PositiveArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
