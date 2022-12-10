//определение массива
int Max(int arg1, int arg2, int arg3) 
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}// индекс      0   1   2   3   4   5   6   7   8
int [] array = {11, 12, 13, 14, 51, 61, 71, 18, 19} ;
array [0] = 12; //записать знаение в массив

Console.WriteLine(array[0]); //получить значение из массива

