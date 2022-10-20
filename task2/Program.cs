// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] WriteArray()
 {
 int [] array = new int [4];
 
 for(int i = 0; i < array.Length; i++)
 {
    array[i] = new Random().Next(0,10);
 }
 return array;
 }

void PrintArray( int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    System.Console.Write($" {array [i]}");
    }
}

int SumOddIndexNumbers(int [] array)
{
int sum = 0;
 for(int i = 0; i < array.Length; i++)
 {
    if(i%2 !=0)
    {
      sum= sum + array[i];  
    }
 }  
 return sum; 
}

int [] answer = WriteArray();
PrintArray(answer);
int S = SumOddIndexNumbers(answer);
System.Console.WriteLine($" ->{S}");