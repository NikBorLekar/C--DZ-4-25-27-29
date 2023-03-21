// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

string? Numbers = Console.ReadLine();

Numbers = Numbers + ",";    

//удаление пробелов из строки 
string DelSpace (string series)
{
  string New = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      New += series[i];
    }
  }
  return New;
}

// проверка на правильность ввода 
void СheckNumber2 (int  series)
{

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else 
        {
          Console.WriteLine($"Ошибка ввода, введите цифры");

      }
}

// создание и заполнение массива из строки
int[] ArrayOfNumbers(string seriesNew)
{ 

  int[] arrayOfNumbers = new int[1];    // создаем массив из 1 элемента

  int j =0;
  for (int i = 0; i < seriesNew.Length; i++)
  {
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1)
    {
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}

// вывод массива на печать 
void PrintArray(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count)
  {
    Console.Write(coll[index]);
    index++;
    if (index < count)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

string seriesNew = DelSpace(Numbers);
int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);
PrintArray(arrayOfNumbers);