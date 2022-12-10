//при применении метода void нельзя применять
// возвращающее значение return.
// Данный метод является не возвращающим

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
int[] array = new int[10];// создаем массив по умолчанию 10 элементов

FillArray(array);
PrintArray(array);