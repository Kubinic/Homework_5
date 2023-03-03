/*Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
int sum = 0;
int[] array = GetRandomArray(10, -100, 100);

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int sum_numb_index(int[] array)
{for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];

        }
        
    }
        return sum;
}
sum_numb_index(array);
Console.Write($"{sum} сумму элементов, стоящих на нечётных позициях в массиве ["+ string.Join(", ", array)+"]");