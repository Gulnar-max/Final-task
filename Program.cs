// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Clear();
// int [] newArray (int size, int min, int max)
// {
//     int [] array = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         array [i] = new Random().Next(min, max);
//         Console.WriteLine($"{array[i]} ");  
//     }
//     return array;
// }
// Console.WriteLine("Insert quantity of array");
// int size = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int [] array = newArray(size,100,1000);
// Console.WriteLine();
// for (int i=0; i<size; i++)
// {
//     if(array [i] %2==0) count++;
// }
// Console.WriteLine($"Quantity of even numbers is {count}");

// Console.Clear();
// int [] newArray (int size, int min, int max)
// {
//     int [] array = new int[size];
//     for (int i=0, i < size, i++)
//     {
//         array [i] = new Random().Next(min, max);
//         Console.WriteLine($"{array[i]} ");  
//     }
//     return array;
// }
// Console.WriteLine("Insert quantity of array");
// int size = Convert.ToInt32(Console.ReadLine());
// array [i] = new Random().Next(min, max);
// int count = 0;
// int[] array = newArray(size,100,1000);
// Console.WriteLine();
// for (int i=0; i<size; i++)
// {
//     if(array [i] %2==0) count++;
// }
// Console.WriteLine($"Quantity of even numbers is {count}");







// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Clear();
// int [] newArray (int size, int min, int max)
// {
//     int [] array = new int[size];
//     for (int i=0; i<size; i+=2)
//     {
//         array [i] = new Random().Next(min, max);
//         Console.WriteLine($"{array[i]} ");  
//     }
//     return array;
// }
// Console.WriteLine("Insert quantity of array");
// int size = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int [] array = newArray(size,1,1000);
// Console.WriteLine();
// for (int i=0; i<size; i+=2)
// {
//     sum=sum+array[i];
// }
// Console.WriteLine($"Quantity of even numbers is {sum}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Insert quantity of Array");
int n = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[n];
int i = 0;
int max = 1;
int min = 1000;

while (i<n)
{
    Array[i] = new Random().Next(min,max+1);
    Console.WriteLine($"{Array[i]}");
    if(Array[i]>max) max = Array[i];
    if(Array[i]<min) min = Array[i];
    i++;
}
Console.WriteLine($"Diff btw Max and Min is - {max-min}.");


// Console.Clear();
// int [] newArray (int size, int min, int max)
// {
//     int [] Array = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         Array [i] = new Random().Next(min, max);
//         Console.WriteLine($"{Array[i]} ");  
//     }
//     return Array;
// }
// Console.WriteLine("Insert quantity of array");
// int size = Convert.ToInt32(Console.ReadLine());
// int i=0;
// Array[i]=0;
// int max = 0;
// int min = 0;
// if(Array[i]>max) max = Array[i];
// if(Array[i]<min) min = Array[i];
// Console.WriteLine($"Diff between MAx and Min numbers is {max-min}");
