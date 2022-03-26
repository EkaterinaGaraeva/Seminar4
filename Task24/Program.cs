// Задача 24. Напишите программу, которая приниает
// на вход число (А) и выдает сумму от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumFromOneToNumber(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int A = Convert.ToInt32(Console.ReadLine());

int sum = SumFromOneToNumber(A);

Console.WriteLine($"Сумма от 1 до {A} = {sum}");
