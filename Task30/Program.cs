// Задача 30: Напишите программу, которая выводит массив 
// из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void RandomArray(int[] collection)
{
    for (int i = 0; i <= 7; i++)
    {
        collection[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] col)
{
    for(int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i]);
        if (i < (col.Length - 1))
        {
            Console.Write(", ");
        }
    } 
}

int[] array = new int[8];
RandomArray(array);
PrintArray(array);
Console.WriteLine();


