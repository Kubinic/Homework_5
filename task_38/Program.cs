/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным 
и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double max = 0;
double min = 0;
double[]array = GetRandomArray(10);
double[] GetRandomArray(int size)
{
    
   double[] result = new double[size];
for (int i = 0; i < result.Length; i++)
{result[i] =Math.Round((new Random().NextDouble() * 20), 2);
}
    return result;
}


void DiffMaxMinArr(double [] array){
for (int i = 0; i < array.Length; i++){
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < max){
        min = array[i];
    }
}
Console.WriteLine($"{Math.Round(max - min, 2)} разницу между максимальным и минимальным элементов массива ["+ string.Join(", ", array)+"]");
}
DiffMaxMinArr(array);



