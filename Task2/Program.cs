// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray (int size, int min, int max )
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
   {
      array[i] = new Random().Next(min,max);
   }
   return array;
}

int[] array = CreateArray(20,1,1000);

Console.WriteLine("Массив: " + String.Join(" ", array));

int GetSumOddElements (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int sum = GetSumOddElements (array);

Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);