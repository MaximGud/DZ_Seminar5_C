// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int num)
{
  int[] array = new int[num];
  for (int i = 0; i < num; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
  return array;
}

int CountChet(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count = count + 1;
    }
  }
  return count;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = GetArray(size);

Console.WriteLine($"Массив: [{String.Join(", ",arr)} ]");
Console.Write($"Количество четных элементов массива равно - {CountChet(arr)}");