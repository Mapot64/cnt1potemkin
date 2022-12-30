Console.WriteLine("Сколько элементов Вы хотите ввести? ");
Convert  =  размер  int.ToInt32(консоль.ReadLine());

letter[] arrayStrings = новая  строка[размер];
для (int  i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    Convert = строка элемента .toString(консоль.ReadLine());
    arrayStrings[i] = элемент;
}

letter[] arrayFinal = новая  строка[размер];
3 = len int;
0 =  pos  int;

for (int  j = 0; j < size; j ++)
{
    if (arrayStrings[j].Длина <= len)
    {
        arrayFinal[pos] = arrayStrings[j];
        ++pos;
    }
}

Console.WriteLine();
printArray(arrayFinal);
