//Задача 21
//Напишите программу, 
//которая принимает на вход 
//координаты двух точек и находит 
//расстояние между ними в 2D пространстве.
//A (0,0); B (1,1), -> ~1.4
//A (2,4); B (0,7) -> ~3.6

Console.WriteLine ("start");
char selection;
Double x1, x2, y1, y2, z1, z2, distance;

Console.WriteLine("1. Расстояние между двумя точками на плоскости.");
Console.WriteLine("2. Расстояние между двумя точками в пространстве.");
Console.WriteLine("Выберите нужный пункт (1 или 2):");

selection = Convert.ToChar(Console.ReadLine());

switch (selection)
{
    case '1':
        Console.Write("Введите координаты x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координаты x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координаты y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координаты y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
        Console.ReadKey();
        break;
    case '2':
        Console.Write("Введите координаты x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координаты x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координаты y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координаты y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координаты z1: ");
        z1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координаты z2: ");
        z2 = Convert.ToDouble(Console.ReadLine());

        distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
        Console.ReadKey();
        break;
    default:
        Console.WriteLine("Вы ввели неверный символ");
        Console.ReadKey();
        break;
}