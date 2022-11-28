// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray (int size, double min, double max)
{
    double[] array = new double [size];
    for (int i = 0; i < size; i++)
   {
      array[i] = (new Random().NextDouble()) * (max - min) + min;
   }
   return array;
}

double [] array = CreateArray(20,-100,100);

Console.WriteLine(String.Join(" ", array));

double DiffMaxMin (double [] array)
{
    double max = array [0];
    double min = array [0];
    double diff = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
           max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return max - min;
}

double diff = DiffMaxMin(array);
diff = Math.Round(diff, 2);
Console.WriteLine("Разница между максимальным и минимальным "+ diff); 