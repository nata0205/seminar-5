// Задача 36. Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечетных позициях.
//[3,7,23,12]> 19
//[-4,-6,89,6] ->0
using static system.Console;
Clear(); 
WriteLine ("Введите количество элементов массива:");
int size = Convert.ToInt32(ReadLine());
int []numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteLine("Вот наш массив:");
PrintArray(numbers);
int sum = 0;

for(int z =0; z < numbers.Length; z+= 2)
sum = sum + numbers[z];
WriteLine($"всего {numbers.Length}чисел,сумма элементов на нечетных позициях = {sum}");
void FillArrayRandomNumbers(int[]numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,10);
    }
    {
        void PrintArray(int[]numbers)
    }
    Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
        Write(numbers[i]+"");
    }
    Write("]");
    WriteLine();
}


