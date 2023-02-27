// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Используйте NextDouble().

double[] GetArray(int num)
{
  double[] array = new double[num];
  for (int i = 0; i < num; i++)
  {
    array[i] = Math.Round(new Random().NextDouble(), 2);
  }
  return array;
}

double RaznMaxMin(double[] array)
{
  double result = 0;
  double max = array[0];
  double min = array[0];

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > max)
    {
      max = array[i];
    }
    else if (array[i] < min)
    {
      min = array[i];
    }
  }
  result = max - min;
  return result;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr = GetArray(size);

Console.WriteLine($"Массив: [{String.Join("; ", arr)} ]");
Console.Write($"Разница между максимальным и минимальным элементом массива равна - {Math.Round(RaznMaxMin(arr),2)}");