// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
void isPalindrom(int number)
{
    int number5 = number % 10;
    int number4 = number % 100 / 10;
    int number2 = number / 1000 % 10;
    int number1 = number / 10000;
    if (number1 == number5 & number2 == number4) Console.Write("да");
    else Console.Write("нет");
}
int getNumber(String text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int number = getNumber("Введите любое пятизначное число");
isPalindrom(number);