// Задача 30: Напишите программу, которая выводит массив 
// из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] RandomArray(int length)
{
    int[] returningArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(0, 2);
    }
    return returningArray;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for(int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < (arrayToPrint.Length - 1))
        {
            Console.Write(", ");
        }
    } 
    Console.Write("]");
    Console.WriteLine();
}

int[] arrayNumberOne = RandomArray(5);
PrintArray(arrayNumberOne);

int[] arrayNumberTwo = RandomArray(20);
PrintArray(arrayNumberTwo);

int[] arrayNumberThree = RandomArray(8);
PrintArray(arrayNumberThree);


