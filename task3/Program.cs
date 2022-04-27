int [] array = {1,12,31,4,15,16,17,18,31};
int n = array.Length;
int find = 31;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //заканчивает цикл и показывает только первый элемент
    }
    index++; //аналогично index = index + 1
}