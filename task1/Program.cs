// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] WriteArray()
 {
 int [] array = new int [8];
 
 for(int i = 0; i < array.Length; i++)
 {
    array[i] = new Random().Next(100,999);
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

int FindingEvenNumbers(int [] array)
{
    int value = 0;
    for(int i = 0; i < array.Length; i++)
 {
    if (array [i] % 2==0)
    {
        value = value+1;
    }
 }
return value;
}


int [] answer = WriteArray();
PrintArray(answer);
int count = FindingEvenNumbers(answer);
System.Console.WriteLine($" ->{count}");