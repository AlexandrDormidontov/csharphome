
int[ ] array = { 1, 57, 13, 4, 5, 13, 57, 8 };

int n = array.Length;
int find = 57;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);// находит все индексы с заданным числом
        break;// останавливается на первом найденном индексе заданного числа
    }
    //index = index + 1;
    index ++;
}