// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] WriteArray()
 {
 double [] array = new double [4];
 
 for(int i = 0; i < array.Length; i++)
 {
    array[i] = new Random().Next(0,10);
 }
 return array;
 }

void PrintArray( double [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    System.Console.Write($" {array [i]}");
    }
}

double MaxNumber(double [] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]>max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinNumber(double [] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]<min)
        {
            min = array[i];
        }
    }
    return min;
}

double [] answer = WriteArray();
PrintArray(answer);
double min1 = MinNumber(answer);
double max1 = MaxNumber(answer);
double value = max1 - min1;
System.Console.WriteLine($" -> {value}");