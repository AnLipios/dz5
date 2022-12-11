//Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.

Console.Clear();
int[] array = PositiveArray(8, 0, 20);
Console.WriteLine(String.Join(" ", array));

int notEvenSum = 0;
for (int i = 1; i<array.Length; i=i+2){
    int u = array[i];
    
    notEvenSum += u;

    }

Console.WriteLine($"Сумма чисел, стоящих на нечётых позициях: {notEvenSum}");
int[] PositiveArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
