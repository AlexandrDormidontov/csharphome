// Напишите программу, которая принимает 
//на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("start");
int a = 2;
int b = 3;
int c = 7;
int max = a;
if (b > max)
{
    if (b > c)
    {
        b = max;
        Console.WriteLine("max");
    }
    else 
    { 
        c = max;
        Console.WriteLine("max");
        }
 else
 {
    c > max;
    max = c;
 }       
}