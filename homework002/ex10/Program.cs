//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6, 7 - выходной.
// дня с индексом 0 или 12 не существует.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine ("start");
Console.WriteLine ("Введите день недели от 1 до 7, ");
int a = Convert.ToInt32(Console.ReadLine());
   if (a == 6) 
{
    Console.WriteLine("да");
}
    else if (a == 7)
    {
        Console.WriteLine("да");
    }
    else if (a == 5)
    {
        Console.WriteLine ("нет");
    }
    else if (a == 4)
    {
        Console.WriteLine ("нет");
    }
    else if (a == 3)
    {
        Console.WriteLine ("нет");
    }
    else if (a == 2)
    {
        Console.WriteLine ("нет");
    }
    else if (a == 1)
    {
        Console.WriteLine ("нет");
    }
else
{
   Console.WriteLine("введеное число не входит в предложеный диапазон"); 
}
