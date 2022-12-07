//Напишите программу, которая на вход принимает число
//и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("start");

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) //запись проверки числа на четность
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число нечетное");
}
Console.WriteLine("end");
