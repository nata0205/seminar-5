// Задача 38. Задайте массив вещественных чисел.
//Найдите разницу между max и min элементов массива.
//[3722278] ->76
using static System.Console;
Clear();
WriteLine("Введите размер массива");
int size = Convert.ToInt32(ReadLine());
double[]numbers = new double[size];
FillArrayRandomNumbers(numbers);
WriteLine("Вот получившийся массив:");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for(int z = 0;z < numbers.Length; z++)
{
    if(numbers[z]>max)
    {
        max = numbers[z];
    }
    if(numbers[z]<min)
    {
        min = numbers[z];
    }
}
WriteLine($"всего{numbers.Length}чисел.max значение = {max},min значение = {min}");
WriteLine($"разница между max и min значением = {max-min}");

void FillArrayRandomNumbers(double[]numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(1,10));
    }
}
void PrintArray(double[]min)
{
    Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
        Write(numbers[i]+"");
    }
}
Write("]");
WriteLine();