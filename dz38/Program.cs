//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и 
//минимальным элементов массива.

Console.Clear();
Double[] array = GoodArray(7, 0, 2);
Console.WriteLine(String.Join(" ", array));

double sum = 0;
double maxNum = array[0];
double minNum = array[0];

foreach (double n in array)
{
    if (minNum < n) minNum = n;
    if (maxNum > n) maxNum = n;
sum = minNum - maxNum;
}

Console.WriteLine($"Разница между максимальным и минимальным: {sum}");
double[] GoodArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        
    }
    return res;
}