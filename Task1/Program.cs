// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray (int size, int min, int max )
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
   {
      array[i] = new Random().Next(min,max);
   }
   return array;
}

int[] array = CreateArray(20,100,1000);

Console.WriteLine(String.Join(" ", array));

int GetEvenElementsCount(int[] array)
{
    int evenElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenElements += 1;
        }
    }
    return evenElements;
}

int evenElements = GetEvenElementsCount(array);

Console.WriteLine(evenElements);