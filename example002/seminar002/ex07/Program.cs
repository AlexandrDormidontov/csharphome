void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); 
        //index = index + 1
        index ++;
    } 


}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position ++;
        
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;//ставят -1, чтобы было понятно, что искомого элемента не найдено
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; //останавливает цикл при обнаружении первого совпадения
        }
        index ++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
array[4] = 4;//в массив добавляем 4 на 4 индекс
array[6] = 4;// в массом добавляем 4 на 6 индекс

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 43);
Console.WriteLine(pos);