//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void CheckPalindrome(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int First2Digit = number / 1000;
    int Last2Digit = number % 100;
    if (First2Digit % 10 == Last2Digit / 10)
        Console.WriteLine("Number is Palindrome");
    else
        Console.WriteLine("Number is not a Palindrome");
}


CheckPalindrome("Insert a 5 digit number");
