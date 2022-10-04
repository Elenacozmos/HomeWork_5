//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] numbers = new int[10];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив заполненный случайными положительными трёхзначными числами: ");
PrintArray(numbers);
int count = 0;
for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;
Console.WriteLine($"Количество чётных чисел в массиве - {count}");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        numbers[i] = new Random().Next(100,1000);
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++) 
        Console.Write(numbers[i] + " ");
             Console.WriteLine();
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] numbers = new int[5];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Одномерный массив, заполненный случайными числами: ");
PrintArray(numbers);
int sum = 0;

    for (int i = 0; i < numbers.Length; i+=2)
        sum = sum + numbers[i];
        Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях (1, 3, 5) - {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    
        numbers[i] = new Random().Next(1,10);
    
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
             Console.WriteLine();
}


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] numbers = new double[10];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив вещественных чисел: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        
            max = numbers[i];
        
    if (numbers[i] < min)
        
            min = numbers[i];
        
}
Console.WriteLine($"Разница между максимальным и минимальным значением Составляет = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        
            numbers[i] = Convert.ToDouble(new Random().Next(1,100));
        
}
void PrintArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        
            Console.Write(numbers[i] + " ");
        
    Console.WriteLine();
}