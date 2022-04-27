void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}


void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}

int IndexOf(int[]collection, int find) // метод отличный от Void для поиска числа
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // указываем -1, чтобы при поиске несувществующего числа не показывал по умолчанию индекс 0
    while(index < count)
    {
        if(collection[index] == find)
        {
          position = index;
          break; // чтобы остановить после нахождения первого вхождения эл-та 4 в массиве,
                //по умолчанию показывает индекс последней 4ки в массиве
        }
        index++;
    }
    return position;
}

int [] array = new int[10];

FillArray(array);
array[3] = 4; //принудительно присвоили позицию 4ки
array[7] = 4; //принудительно присвоили позицию 4ки
PrintArray(array);
Console.WriteLine(); // вывели пустую строку чтобы разделить

int pos = IndexOf(array, 413); // ищем индекс числа 4 в массиве
Console.WriteLine(pos); // написать индекс pos