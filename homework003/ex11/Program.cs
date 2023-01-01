//Задача 19
//Напишите программу, которая принимает
// на вход пятизначное число и проверяет,
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine ("start");
Console.WriteLine ("Введите пятизначное число, ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number/1000 == (number%10)*10 + (number%100)/10 ? "палиндром" : "не палиндром");