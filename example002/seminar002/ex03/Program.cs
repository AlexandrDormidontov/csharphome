//найти максимальную из 9 переменных
int Max(int arg1, int arg2, int arg3) //строки от 2 до 8 это поиск максимального из трех 
{
    int result = arg1;      
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 15; 
int b1 = 21;
int c1 = 319;
int a2 = 12; 
int b2 = 23;
int c2 = 33;
int a3 = 12; 
int b3 = 223;
int c3 = 33;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);
int max = Max(Max(a1, b1, c1), 
Max(a2, b2, c2), 
Max(a3, b3, c3)); //эту запись можно делять в одну строку

Console.WriteLine (max);

//int max = a1;
//if (b1 > max ) max = b1;