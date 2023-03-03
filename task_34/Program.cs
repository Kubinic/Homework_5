/*Задача 34: Задайте массив 
заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int[] array = GetRandomArray(7, 100, 999);
int count = 0;
count_numbers_arr(array);
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int count_numbers_arr (int [] array){

for(int i = 0; i< array.Length; i++){
    if (array[i] % 2 == 0)
        count++;
}
    return count;
}


Console.Write($"{count} чётных чисел в массиве ["+ string.Join(", ", array)+"]");

