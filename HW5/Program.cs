/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

/*int size = Input("Введите размер массива: ");
int[] array = new int[size];
int countPositive = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
}

PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    if( array[i] % 2 ==0)
    countPositive = countPositive +1; 
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}
 
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Write($"Количество четных чисел в массиве = { countPositive}");*/


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

/*int size = Input("Введите размер массива: ");
int[] array = new int[size];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10,100);
}

PrintArray(array);

for (int i = 1; i < array.Length; i+=2)
{   
    sum = sum + array[i];  
}
Console.Write(sum);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}
 
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}*/


/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int size = Input("Введите размер массива: ");
double[] array = new double[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble(new Random().Next(-100,1000))/10;
}

PrintArray(array);
Console.Write($"Разница равна = {MethodMax(array) - MethodMin(array)}");

double MethodMin(double[] array)
{
    double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }    
}
return min;
}

double MethodMax (double[] array)
{
    double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }    
}
return max;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}
 
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

