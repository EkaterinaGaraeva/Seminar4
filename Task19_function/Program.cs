// Задача 19 функция

string IsNumberPolindrom(int number)
{
string returnMessage = $" {number}";
if(number > 9999 && number < 100000)
{
    int[] digits = new int[5];
    for (int i = 0; i < digits.Length; i++)
    {
        digits[i] = number % 10;
        number /= 10;
    }
    if(digits[0] == digits[4] && digits[1] == digits[3])
    {
        returnMessage += "- это полиндром";
    }
    else
    {
        returnMessage += "- это не полиндром";
    }
}
else 
{
    returnMessage += "- это не пятизначное число";
}
    return returnMessage;
}

int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());
string returnMessage = IsNumberPolindrom(fiveDigitNumber);

Console.WriteLine(returnMessage);
