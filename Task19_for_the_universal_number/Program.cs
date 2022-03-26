// Задача 19 для универсального числа

int reverseNumber(int number)
{
    int reverseNumber = new int();
    while (number > 0)
    {
        int lastDigit = number % 10;
        reverseNumber = reverseNumber * 10 + lastDigit;
        number /= 10;
    }
    return reverseNumber;
}


string IsNumberPolindrom(int number)
{
    string returnMessage = $" {number}";

    int reversedNumber = reverseNumber(number);
    if(reversedNumber == number)
    {
        returnMessage += "- это полиндром";
    }
    else
    {
        returnMessage += "- это не полиндром";
    }
    return returnMessage;
}

int number = Convert.ToInt32(Console.ReadLine());
string returnMessage = IsNumberPolindrom(number);

Console.WriteLine(returnMessage);
