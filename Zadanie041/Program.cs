/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
вводим через один Enter (разбиваем через Split())*/

int[] GetArray()
{
  Console.WriteLine("Введите любое количество целых чисел, разделенных пробелами, запятыми или точками");
  string text = Console.ReadLine()!;
  char[] separators = new char[] { ' ', ',', '.' };
  string[] splitArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
  int[] ArrayNumbers = new int[splitArray.Length];
  int digit = 0;

  for (int i = 0; i < ArrayNumbers.Length; i++)
  {
    if (int.TryParse(splitArray[i], out digit)) ArrayNumbers[i] = digit;
  }
  return ArrayNumbers;
}

int CountPositNumbers(int[] Array)
{
  int count = 0;
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i] > 0) count = count + 1;
  }
  return count;
}

int[] Array = GetArray();
Console.WriteLine();
Console.WriteLine($"Введенный массив = [{(string.Join(',', Array))}]");
int Count = CountPositNumbers(Array);
Console.WriteLine($"Количество положительных чисел в введенном массиве = {Count}");

