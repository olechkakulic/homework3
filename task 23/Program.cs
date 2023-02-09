// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void getCount(int x)
{
    for (int i = 1; i < x + 1; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}
int getNumber(string text)
{
    Console.WriteLine(text);
    int value = int.Parse(Console.ReadLine());
    return value;
}
int x = getNumber("Введите любое число");
getCount(x);
