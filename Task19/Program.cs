int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());
string returnMessage = $" {fiveDigitNumber}";
if(fiveDigitNumber > 9999 && fiveDigitNumber < 100000)
{
    int[] digits = new int[5];
    for (int i = 0; i < digits.Length; i++)
    {
        digits[i] = fiveDigitNumber % 10;
        fiveDigitNumber /= 10;
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

Console.WriteLine(returnMessage);
