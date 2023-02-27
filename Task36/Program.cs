// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GetArray(int num)
{
  int[] array = new int[num];
  for (int i = 0; i < num; i++)
  {
    array[i] = new Random().Next(-10, 10);
  }
  return array;
}

int SumNechInd(int[] array)
{
  int sum = 0;
  for (int i = 1; i < array.Length; i=i+2)
    {
    sum += array[i];
    }
  return sum;
}
  
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = GetArray(size);

Console.WriteLine($"Массив: [{String.Join(", ",arr)} ]");
Console.Write($"Сумма элементов, стоящих на нечетных позициях равна - {SumNechInd(arr)}");
