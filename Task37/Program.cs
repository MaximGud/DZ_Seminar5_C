// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int num)
{
  int[] array = new int[num];
  for (int i = 0; i < num; i++)
  {
    array[i] = new Random().Next(0, 10);
  }
  return array;
}

int[] GetNewArray(int[] array)
{
  int size = array.Length;

  int newSize = 0;
  if (size % 2 == 1)
  {
    newSize = (size / 2) + 1;
  }
  else
    newSize = size / 2;

  int[] newArray = new int[newSize];
  {
    for (int i = 0; i < size / 2; i++)
    {
      newArray[i] = array[i] * array[size - i - 1];
    }
    if (size % 2 == 1)
    {
      newArray[newSize - 1] = array[newSize - 1];
    }
   }
   return newArray;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = GetArray(size);

Console.WriteLine($"Массив: [{String.Join(";", arr)} ]");
Console.Write($"Массив произведения чисел: [{String.Join(";", GetNewArray(arr))}]");