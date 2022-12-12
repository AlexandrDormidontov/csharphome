//Напишите программу, которая выводит третью
//цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("start");

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

while(a > 1000) a/= 10;
Console.WriteLine(a%10);



Console.WriteLine("третьей цифры нет");
